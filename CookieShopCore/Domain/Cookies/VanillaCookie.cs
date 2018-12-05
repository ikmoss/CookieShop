using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieShopCore.Domain.Cookies
{
    public class VanillaCookie : CookieBase
    {
        public VanillaCookie() : base("Vanilla", 200)
        {
        }

        public override bool IsBurnt(int ovenTemp)
        {
            return base.IsBurnt(ovenTemp);
        }


    }
}
