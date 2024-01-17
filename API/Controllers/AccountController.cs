using System.Security.Cryptography;
using System.Text;
using API.Controllers;
using API.Data;
using API.DTOs;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

public class AccountController: BaseController
{
    private readonly DataContext _context;

    public AccountController(DataContext context) {
        _context = context;
    }

    [HttpPost("register")] // POST : api/account/register
    
    public async Task<ActionResult<AppUser>> Register(Registerdto registerdto) {

        if(await UserExists(registerdto.Username)) return BadRequest("Username is taken :(");
        using var hmac = new HMACSHA512();
        var user = new AppUser
        {
             UserName = registerdto.Username.ToLower(),
             PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(registerdto.Password)),
             PasswordSalt = hmac.Key,

        };

        _context.Users.Add(user);
        await _context.SaveChangesAsync();
        return user;


    }        
    private async Task<bool> UserExists(string username){
            return await _context.Users.AnyAsync(x => x.UserName == username.ToLower());
        }
}
