using ScreenColor.Common.Interfaces;

namespace ScreenColor.Common.Services
{
    public class GreenService : IColorService
    {
        public string GetColor()
        {
            return "Green";
        }
    }
}