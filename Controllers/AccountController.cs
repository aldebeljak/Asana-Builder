using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AsanaBuilder.DAL;
using AsanaBuilder.Models;

namespace AsanaBuilder.Controllers
{
    public class AccountController : Controller
    {
        private IUserDAO userDAO;
        public AccountController(IUserDAO userDAO)
        {
            this.userDAO = userDAO;
        }
    public IActionResult Profile()
        {
           User user = userDAO.GetUser("and21@case.edu");
            return View(user);
        }
    }
}