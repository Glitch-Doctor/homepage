using Glitchdoctor.Models;
using Glitchdoctor.Services;
using Glitchdoctor.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Linq;

namespace Glitchdoctor.Controllers.Web
{
    public class AppController : Controller
    {
        private IConfigurationRoot _config;
        private IMailService _mailService;
        private PollContext _context;

        public AppController(IConfigurationRoot config, IMailService mailService, PollContext context)
        {
            _config = config;
            _mailService = mailService;
            _context = context;
        }

        public IActionResult Index()
        {
            var recentPolls = _context.Polls.ToList();

            return View(recentPolls);
        }

        public IActionResult MainAccounts()
        {
            return View();
        }

        public IActionResult Poll()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(ContactViewModel vm)
        {
            if (ModelState.IsValid)
            {
                _mailService.SendMail(_config["MailSettings:ToAddress"], vm.Email, "From TestSite", vm.Message);

                ModelState.Clear();

                ViewBag.UserMessage = "Message Sent";
            }

            return View();
        }
    }
}
