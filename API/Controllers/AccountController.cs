using System.Security.Cryptography;
using System.Text;
using API.Controllers;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class AccountController: BaseController
{
    private readonly DataContext _context;

    public AccountController(DataContext context) {
        _context = context;
    }

    [HttpPost("register")] // POST : api/account/register
    
    public async Task<ActionResult<AppUser>> Register(string username, string password) {
        using var hmac = new HMACSHA3_512();
        var user = new AppUser
        {
             UserName = username;
             PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));

        }

    }
}
