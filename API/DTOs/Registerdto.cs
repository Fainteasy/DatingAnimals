﻿using System.ComponentModel.DataAnnotations;

namespace API.DTOs;

public class Registerdto
{
    [Required]
    public string Username {get; set;}

    [Required] public string KnownAs { get; set; }
    [Required] public string Genre { get; set; }
    [Required] public DateOnly? DateOfBirth { get; set; } // optional to make required work
    [Required] public string City { get; set; }
    [Required] public string Race { get; set; }

    [Required] public bool IsSterilized { get; set; }

    [Required]
    [StringLength(8, MinimumLength = 4)]
    public string Password {get; set;}
}

