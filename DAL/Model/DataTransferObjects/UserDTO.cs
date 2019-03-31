using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model.DataTransferObjects
{
    public class UserDTO : Interfaces.IUserDTO, Interfaces.IUserSmallDTO
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public bool IsAdmin { get; set; }
        public string Email { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string UserPassword { get; set; }
    }
}
