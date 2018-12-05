using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieShopCore.Domain.Cookies
{
    public class ChocolateChipCookie:CookieBase
    {
        public ChocolateChipCookie() : base("ChocChipCookie", 180)
        {
        }

        public override bool IsBurnt(int ovenTemp)
        {
            return (CookingTemp - 10) < ovenTemp;
        }
    }
}
