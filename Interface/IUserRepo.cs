using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public interface IUserRepo
    {
        /// <summary>
        /// Visszaad minden felhasználót
        /// </summary>
        /// <returns></returns>
        ICollection<IUserSmallDTO> GetUsers();
        /// <summary>
        /// 1 felhasználót ad vissza
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        IUserSmallDTO GetUsers(int userId);
        /// <summary>
        /// 1 listányi felhasználót ad neked vissza
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        ICollection<IUserSmallDTO> GetUsers(List<int> userId);
        void Registration(IUserDTO udto);
        IUserDTO Login(IUserDTO udto);


    }
}
