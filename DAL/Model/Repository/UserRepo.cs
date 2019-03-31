using System;
using System.Collections.Generic;
using System.Text;
using Interfaces;
using System.Linq;

namespace DAL.Model.Repository
{
    public class UserRepo : IUserRepo
    {
        private readonly AruhazContext _ctx;
        public UserRepo(AruhazContext ctx)
        {
            _ctx = ctx;
        }
        public ICollection<IUserSmallDTO> GetUsers()
        {
            List<IUserSmallDTO> us = new List<IUserSmallDTO>();
            foreach (var item in _ctx.Users)
            {
                us.Add(item);
            }
            return us;
        }

        public IUserSmallDTO GetUsers(int userId)
        {
            return _ctx.Users.First(x => x.UserId == userId);
        }

        public ICollection<IUserSmallDTO> GetUsers(List<int> userId)
        {
            List<IUserSmallDTO> us = new List<IUserSmallDTO>();
            foreach (int item in userId)
            {
                us.Add(_ctx.Users.First(x => x.UserId == item));
            }
            return us;
        }
        public void Registration(Interfaces.IUserDTO udto)
        {
            if (string.IsNullOrWhiteSpace(udto.UserPassword)) throw new ApplicationException("Password is needed");
            if (string.IsNullOrWhiteSpace(udto.UserName)) throw new ApplicationException("Username is needed");
            if (_ctx.Users.Any(x => x.UserName == udto.UserName)) throw new ApplicationException("Username is taken");
            if (_ctx.Users.Any(x => x.Email == udto.Email)) throw new ApplicationException("There is a registered user with this e-mail address");

            byte[] passwordHash, passwordSalt;
            CreatePasswordHash(udto.UserPassword, out passwordHash, out passwordSalt);

            User u = new User
            {
                Email = udto.Email.ToLower(),
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                UserName = udto.UserName
            };
            _ctx.Add(u);
            _ctx.SaveChanges();
        }
        /// <summary>
        /// return 
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public IUserDTO Login(Interfaces.IUserDTO udto)
        {
            if (string.IsNullOrWhiteSpace(udto.Email) || string.IsNullOrWhiteSpace(udto.UserPassword))
                return null;

            User u = _ctx.Users.FirstOrDefault(y => y.Email == udto.Email.ToLower());
            if (u == null)
                return null;

            if (!VerifyPasswordHash(udto.UserPassword, u.PasswordHash, u.PasswordSalt))
            {
                return null;
            }
            var returnUdto = new DAL.Model.DataTransferObjects.UserDTO
            {
                Email = u.Email,
                IsAdmin = u.IsAdmin,
                UserName = u.UserName,
                UserId = u.UserId
            };
            return returnUdto;
        }

        private static bool VerifyPasswordHash(string password, byte[] storedHash, byte[] storedSalt)
        {
            if (storedHash.Length != 64)
            {
                throw new ArgumentException("Nem megfelelő hosszúságú a hash.", "passwordHash");
            }
            if (storedSalt.Length != 128)
            {
                throw new ArgumentException("Nem megfelelő hosszúságú a salt.", "passwordHash");
            }
            using (var hmac = new System.Security.Cryptography.HMACSHA512(storedSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != storedHash[i]) return false;
                }
            }

            return true;
        }

        private static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] PasswordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                PasswordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }
    }
}
