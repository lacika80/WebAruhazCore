using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public interface IUserDTO
    {
        int UserId { get; set; }
        string UserName { get; set; }
        bool IsAdmin { get; set; }
        string UserPassword { get; set; }
        byte[] PasswordHash { get; set; }
        byte[] PasswordSalt { get; set; }
        string Email { get; set; }
    }
}
