using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using reactTodoBackend.Models;

namespace reactTodoBackend.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DBController : ControllerBase
    {
        private readonly DBContext dBContext;
        public DBController()
        {
            dBContext = new DBContext();
        }
        [HttpGet("/add")]
        public string AddUser()
        {
            Models.User newuser = new Models.User();
            newuser.Name = "deneme";
            newuser.Email = "keremayseli@outlook.com";
            dBContext.AddUser(newuser);
            return "deneme";
        }
    }
}