using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAruhazReact.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        [HttpGet("[action]")]
        public JsonResult GetSession(List<string> keys)
        {
            keys.Add("Name");
            keys.Add("LoginTime");
            HttpContext.Session.SetString("Name", "senki");
            HttpContext.Session.SetString("LoginTime", "most");
            DAL.Model.DataTransferObjects.CookieDTO[] icookies = new DAL.Model.DataTransferObjects.CookieDTO[keys.Count];
            for (int i = 0; i < keys.Count; i++)
            {
                DAL.Model.DataTransferObjects.CookieDTO icookie = new DAL.Model.DataTransferObjects.CookieDTO
                {
                    Keyw = keys[i],
                    Valuew = HttpContext.Session.GetString(keys[i])
                };
                icookies[i] = icookie;
            }
            //Dictionary<string, string> icookie = new Dictionary<string, string>();
            //icookie.Add("Name", HttpContext.Session.GetString("Name"));
            //icookie.Add("LoginTime", HttpContext.Session.GetString("LoginTime"));
            //var icookie = new List<string> { HttpContext.Session.GetString("Name"), HttpContext.Session.GetString("LoginTime") };
            return Json(icookies);
        }
        [HttpPost("[action]")]
        public JsonResult Registration(DAL.Model.DataTransferObjects.UserDTO u)
        {
            throw new NotImplementedException();
        }
        [HttpPost("[action]")]
        public JsonResult Login()
        {
            throw new NotImplementedException();
        }
        [HttpPost("[action]")]
        public JsonResult Logout()
        {
            throw new NotImplementedException();
        }
        [HttpPost("[action]")]
        public JsonResult MyPanel()
        {
            throw new NotImplementedException();
        }
        [HttpPost("[action]")]
        public JsonResult MyPanelChange()
        {
            throw new NotImplementedException();
        }
    }
}