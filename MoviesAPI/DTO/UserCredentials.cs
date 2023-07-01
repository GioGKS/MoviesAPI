﻿using System;
using System.ComponentModel.DataAnnotations;

namespace MoviesAPI.DTO
{
	public class UserCredentials
	{
		[Required]
		[EmailAddress]
		public string Email { get; set; }
		[Required]
		public string Password { get; set; }
	}
}

