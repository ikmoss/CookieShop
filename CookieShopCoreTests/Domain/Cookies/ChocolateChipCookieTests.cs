using Microsoft.VisualStudio.TestTools.UnitTesting;
using CookieShopCore.Domain.Cookies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieShopCore.Domain.Cookies.Tests
{
    [TestClass()]
    public class ChocolateChipCookieTests
    {
        [TestMethod()]
        public void ChocolateChipCookie_IsBurntTest()
        {
            //Arrange
            var ccCookie = new ChocolateChipCookie();

            //Act
            var isBurnt = ccCookie.IsBurnt(400);

            //Assert
            Assert.IsTrue(isBurnt);
        }

        [TestMethod()]
        public void ChocolateChipCookie_SetCanEatTest()
        {
            //Arrange
            var ccCookie = new ChocolateChipCookie();

            //Act
            ccCookie.SetCanEat(true);

            //Assert
            Assert.IsTrue(ccCookie.CanEat);
        }
    }
}