using Microsoft.AspNetCore.Mvc;
using ScreenColor.Common.Interfaces;

namespace ScreenColor.NetCore.Controllers
{
    public class ColorController : Controller
    {
        private readonly IColorService _colorService;

        public ColorController(IColorService colorService)
        {
            _colorService = colorService;
        }

        public ActionResult Index()
        {
            return View(_colorService.GetColor());
        }
    }
}