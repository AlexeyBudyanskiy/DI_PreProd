using ScreenColor.Common.Interfaces;

namespace ScreenColor.Common.Services
{
    public class RedService : IColorService
    {
        public string GetColor()
        {
            return "Red";
        }
    }
}