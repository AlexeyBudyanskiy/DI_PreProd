using System.Web.Mvc;
using ScreenColor.Common.Interfaces;

namespace ScreenColor.Autofac.Controllers
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