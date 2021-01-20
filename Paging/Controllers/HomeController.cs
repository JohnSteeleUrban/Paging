using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using Paging.Models;

using System.Diagnostics;
using Microsoft.AspNetCore.Http;
using PagingExampleApp.Models;
using PagingExampleApp.Models.Shared;

namespace Paging.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(int? page, string search)
        {
            ViewBag.Search = search;
            PagerDataModel<Person> usersDataModel;
            try
            {
                // var userClient = new PersonClient();
                //  var users = await userClient.Users();
                // usersModel = users.ToPagerModel(search, page ?? 1);
            }
            catch (Exception exception)
            {
                return View("Error", new ErrorViewModel { ErrorMessage = $"Error: {exception.Message} {exception.InnerException}" });
            }

            return View(usersDataModel);
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
