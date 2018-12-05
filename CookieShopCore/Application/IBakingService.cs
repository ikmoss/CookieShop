using CookieShopCore.Domain.Cookies;

namespace CookieShopCore.Application
{
    public interface IBakingService
    {
        int OvenTemperature { get; set; }

        void BakeCookie(ICookie cookie);
    }
}