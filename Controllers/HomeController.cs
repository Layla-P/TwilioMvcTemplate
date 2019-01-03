using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using TwilioMvcTemplate.Models;
using Twilio;

namespace TwilioMvcTemplate.Controllers
{
    public class HomeController : Controller
    {
        private readonly TwilioAccount _twilioAccount;

        // Your TwilioAccount is set up in the Startup.cs file

        public HomeController(IOptions<TwilioAccount> options)
        {
            if(options==null){
                throw new ArgumentException(nameof(options));
            }
            _twilioAccount = options.Value;

        }
        public IActionResult Index()
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
