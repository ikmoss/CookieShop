using Microsoft.VisualStudio.TestTools.UnitTesting;
using CookieShopCore.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CookieShopCore.Domain.Cookies;
using NSubstitute;

namespace CookieShopCore.Application.Tests
{
    [TestClass()]
    public class BakingServiceTests
    {
        [TestMethod()]
        public void BakingService_BakeCookieTest()
        {
            //Arrange
            var aCookie = Substitute.For<ICookie>();
            var bakingService = new BakingService(200);


            //Act
            bakingService.BakeCookie(aCookie);

            //Assert
            aCookie.Received().IsBurnt(Arg.Any<int>());
            aCookie.Received().SetCanEat(Arg.Any<bool>());
        }

        [TestMethod()]
        public void BakingService_BakeCookieTest2()
        {
            //Arrange
            var aCookie = new ChocolateChipCookie();
            var bakingService = new BakingService(200);

            //Act
            bakingService.BakeCookie(aCookie);

            //Assert
            Assert.IsFalse(aCookie.CanEat);
        }
    }
}