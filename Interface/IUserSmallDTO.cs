using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public interface IUserSmallDTO
    {
        int UserId { get; set; }
        string UserName { get; set; }
        bool IsAdmin { get; set; }
        string Email { get; set; }
    }
}
