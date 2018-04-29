using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Hexagons.Models;
using Hexagons.Services;

namespace Hexagons.Controllers
{
    public class HomeController : Controller
    {
        private IBuildsService _service;

        public HomeController(IBuildsService service)
        {
            _service = service;
        }
        public IActionResult Index()
        {
            var builds = _service.GetBuilds();
            var hexagonDrawer = new HexagonDrawer().DrawHexagons(builds).GetEnumerator();
            List<BuildViewModel> buildvms = new List<BuildViewModel>();
            foreach (var b in builds.Builds)
            {
                hexagonDrawer.MoveNext();
                buildvms.Add(new BuildViewModel
                {
                    Tooltip = b.name,
                    Score = b.score.ToString(),
                    Path = hexagonDrawer.Current
                });
                
            }
            return View(new BuildsViewModel
            {
                Builds = buildvms
            });
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
