using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieShopCore.Domain.Cookies
{
    public abstract class CookieBase: ICookie
    {
        readonly int _CookingTemp;
        readonly string _Name;
        private bool _CanEat;

        public bool CanEat { get { return _CanEat; } }
        public int CookingTemp { get { return _CookingTemp; } }
        public string Name
        {
            get
            {
                return _Name;
            }
        }

        public CookieBase(string name, int cookingTemp)
        {
            _CookingTemp = cookingTemp;
            _Name = name;
        }

        public virtual bool IsBurnt(int ovenTemp)
        {
            return (CookingTemp + 20) > ovenTemp;
        }

        public void SetCanEat(bool canEat)
        {
            _CanEat = canEat;
        }
    }
}
