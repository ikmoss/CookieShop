using CookieShopCore.Domain.Cookies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieShopCore.Application
{
    public class BakingService : IBakingService
    {
        public int OvenTemperature { get; set; }
        public BakingService(int ovenTemp)
        {
            this.OvenTemperature = ovenTemp;
        }

        public void BakeCookie(ICookie cookie)
        {
            if (cookie.IsBurnt(OvenTemperature))
            {
                cookie.SetCanEat(false);
            }
            else
            {
                cookie.SetCanEat(true);
            }
        }
    }
}
