using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using Web_BackEnd.Models;
using Web_BackEnd.Services;

namespace Web_BackEnd.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private IProgramService _programService;
        public HomeController(ILogger<HomeController> logger,IProgramService programService)
        {
            _logger = logger;
            _programService = programService;
        }

        //Show List of all Programs in Humor category and not archived also has podcast and show in groups with channel (P1,P2,P3)
        public async Task<IActionResult> Index()
        {
            var list = await _programService.GetPrograms();
            return View(list);
        }

        //Show List of all Programs in Humor category
        public async Task<IActionResult> Humor()
        {
            var list = await _programService.GetHumorPrograms();
            return View(list);
        }

        //Show List of all programs has Podcast
        public async Task<IActionResult> HavePodcasts()
        {
            var list = await _programService.GetHavePodcastsPrograms();
            return View(list);
        }

        //Show List of all Programs was not Archived  
        public async Task<IActionResult> NoArchived()
        {
            var list = await _programService.GetNoArchivedPrograms();
            return View(list);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}