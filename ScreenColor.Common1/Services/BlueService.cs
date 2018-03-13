using ScreenColor.Common.Interfaces;

namespace ScreenColor.Common.Services
{
    public class BlueService : IColorService
    {
        public string GetColor()
        {
            return "Blue";
        }
    }
}