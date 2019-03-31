using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAruhazAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly DAL.Model.Repository.ProductRepo _product;
        private readonly DAL.Model.Repository.FilterRepo _category;
        private readonly DAL.Model.Repository.PhotoRepo _photo;
        private readonly DAL.Model.Repository.UserRepo _user;
        private readonly DAL.Model.AruhazContext _ctx;
        public ItemController(DAL.Model.AruhazContext ctx)
        {
            _ctx = ctx;
            _product = new DAL.Model.Repository.ProductRepo(ctx);
            _category = new DAL.Model.Repository.FilterRepo(ctx);
            _photo = new DAL.Model.Repository.PhotoRepo(ctx);
            _user = new DAL.Model.Repository.UserRepo(ctx);
        }

        [HttpGet, Route("~/Item/loader")]
        public ActionResult<List<string>> GetBasics()
        {
            List<string> icookie = new List<string> { HttpContext.Session.GetString("Name"), HttpContext.Session.GetString("LoginTime") };
            return icookie;
        }

        [HttpGet, Route("~/Item/Index")]
        public ActionResult<Dictionary<string, string>> Index()
        {
            #region filler
            //for (int i = 10000; i < 1000000; i++)
            //{
            //    DAL.Model.Filler f = new DAL.Model.Filler
            //    {
            //        Content = i + "asdasdasdasdasdasdasdasdasdasd" + i,
            //        No = i
            //    };
            //    _ctx.Fillers.Add(f);
            //    Console.WriteLine(i);
            //}
            //_ctx.SaveChanges();
            #endregion

            Dictionary<string, string> cookie = new Dictionary<string, string>();
            if (HttpContext.Session.Get("status") == null)
            {
                HttpContext.Session.SetString("status", "guest");
            }
            cookie.Add("status", HttpContext.Session.GetString("status"));
            return cookie;
        }
        [HttpGet, Route("~/Item/Time")]
        public ActionResult<List<string>> Time()
        {
            HttpContext.Session.SetString("ido2", DateTime.Now.ToString());
            List<string> icookie = new List<string> { HttpContext.Session.GetString("ido"), HttpContext.Session.GetString("ido2") };
            return icookie;
        }
        [HttpPost, Route("~/Item/Login")]
        public ActionResult<Dictionary<string, string>> Login(DAL.Model.DataTransferObjects.UserDTO u)
        {
            Dictionary<string, string> cookie = new Dictionary<string, string>();
            if (u.Email == null || u.UserPassword == null)
            {
                cookie.Add("status", "failedlogin");
                return cookie;
            }
            Interfaces.IUserDTO ur=_user.Login(u);
            if (ur.UserId != 0)
            {
                if (ur.IsAdmin == true)
                    HttpContext.Session.SetString("status", "admin");
                else
                    HttpContext.Session.SetString("status", "user");
                cookie.Add("userid", ur.UserId.ToString());
                cookie.Add("status", HttpContext.Session.GetString("status"));
            }
            else
            {
                cookie.Add("status", "failedlogin");
            }
            return cookie;
        }

        [HttpPost, Route("~/Item/Registration")]
        public ActionResult<string> Register(DAL.Model.DataTransferObjects.UserDTO udto)
        {
            _user.Registration(udto);
            return "";
        }
        [HttpPost, Route("~/Item/Logout")]
        public void Logout()
        {
            HttpContext.Session.SetString("status", "guest");
            HttpContext.Session.Remove("Id");
        }

        [HttpGet, Route("~/Item/Admin")]
        public ActionResult<Dictionary<string, string>> AdminPanel()
        {
            Dictionary<string, string> cookie = new Dictionary<string, string>
            {
                { "status", "admin" }
            };
            Redirect("/ Item / Index");
            return cookie;
        }

    }
}