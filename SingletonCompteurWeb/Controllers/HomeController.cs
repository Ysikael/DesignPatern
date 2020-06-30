using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SingletonCompteurWeb.Models;

namespace SingletonCompteurWeb.Controllers
{
    public class HomeController : Controller // il prepare l'affichage pour la vue
    {
        private readonly ILogger<HomeController> _logger;
        private IdUnique idUnique = IdUnique.getSingleton();
        private UsersComments usersComments = UsersComments.getSingleton(); // w devient l'objet dans lequel se trouve le singleton

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //commentsArray.AddComment("comment1");
            //commentsArray.AddComment("comment2");
            //commentsArray.AddComment("comment3");
            ViewData["userComments"] = "";
            ViewData["id"] = idUnique.getNewId();
            foreach (var comment in usersComments.Comments)
            {
                if (ViewData["userComments"] == "")
                {
                    ViewData["userComments"] += $"{comment}";
                }
                else
                {
                    ViewData["userComments"] += $", {comment}";
                }
            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
