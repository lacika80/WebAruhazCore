using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace WebAruhazReactRedux.Controllers
{
    [Authorize]
    [Route("[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly AppSettings _appSettings;
        private readonly DAL.Model.Repository.UserRepo _user;
        private readonly DAL.Model.AruhazContext _ctx;
        public UserController(DAL.Model.AruhazContext ctx, IOptions<AppSettings> appSettings)
        {
            _ctx = ctx;
            _user = new DAL.Model.Repository.UserRepo(ctx);
            _appSettings = appSettings.Value;
        }

        [AllowAnonymous]
        [HttpPost("[action]")]
        public IActionResult Login([FromBody]DAL.Model.DataTransferObjects.UserDTO u)
        {
            var user = _user.Login(u);
            if (user == null) return BadRequest("Uname o Upass is incorrect");
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = System.Text.Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.UserId.ToString())
                }),
                Expires = DateTime.UtcNow.AddDays(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var tokenstring = tokenHandler.WriteToken(token);

            HttpContext.Session.SetString("token", tokenstring);
            HttpContext.Session.SetString("isAdmin", user.IsAdmin.ToString());
            HttpContext.Session.SetString("userName", user.UserName);

            return Ok(new
            {
                Id = user.UserId,
                Username = user.UserName,
                Token = tokenstring,
                IsAdmin = (bool)user.IsAdmin
            });


            //if (u.Email == null || u.UserPassword == null)
            //{
            //    return BadRequest("Username or password is incorrect");
            //}
            //Interfaces.IUserDTO ur = _user.Login(u);
            //if (ur.UserId != 0)
            //{
            //    if (ur.IsAdmin == true)
            //    {
            //        HttpContext.Session.SetString("status", "admin");
            //        return Ok(ur);
            //    }
            //    else
            //    {
            //        HttpContext.Session.SetString("status", "user");
            //        return Ok(ur);
            //    }
            //}
            //else
            //{
            //    return BadRequest("Username or password is incorrect");
            //}
        }
        [AllowAnonymous]
        [HttpPost("[action]")]
        public IActionResult Registration([FromBody] DAL.Model.DataTransferObjects.UserDTO udto)
        {
            try
            {
                _user.Registration(udto);
                return Ok();
            }
            catch (ApplicationException ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}