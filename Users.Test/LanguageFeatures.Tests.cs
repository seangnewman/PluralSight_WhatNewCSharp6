using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace LanguageFeatures.Tests
{
    [TestClass]
    public class Users_Tests
    {
        [TestMethod]
        public void Users_User_Creates_An_Id()
        {

            // Arrange
            var u1 = new User();

            // Act

            // Assert
            Assert.AreNotEqual(Guid.Empty, u1.Id);

        }

        [TestMethod]
        public void Users_Cannot_Create_Money_With_Null_Currency()
        {

            // Arrange
            var expected = "currency";
            var paramName = "";
            try
            {
                var m1 = new Money(1.0m, null);
            }
            catch (ArgumentNullException ex)
            {

                paramName = ex.ParamName;
            }

            var actual = paramName;
            // Act

            // Assert
            Assert.AreEqual(expected, actual);

        }


        [TestMethod]
        public void UserStorage_Can_Have_Default_Users_Present()
        {

            // Arrange
            var expected = 2;
            var store = new UserStorage();
             
            // Act
            var actual = store.Count();
  
            // Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void UserStorage_Can_Add_Users()
        {

            // Arrange
            var store = new UserStorage
            {
                new User("Connor"),
                new User("Cody"),
                new User("Sean")
            };


            var expected = 5;

            // Act
            var actual = store.Count();

            // Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Money_Can_Parse_Money()
        {

            // Arrange
            var input = "12.1 inr";
            var expected = 12.1m;

            // Act
            var actual = Money.Parse(input);

            // Assert
            Assert.AreEqual(expected, actual.Amount);
            Assert.AreEqual("inr", actual.Currency);

        }

        [TestMethod]
        public void Money_Amount_Is_0_When_Amount_Misformatted()
        {

            // Arrange
            var input = "12x.1 inr";
            var expected = 0m;

            // Act
            var actual = Money.Parse(input);

            // Assert
            Assert.AreEqual(expected, actual.Amount);
            Assert.AreEqual("inr", actual.Currency);

        }

        [TestMethod]
        public void Money_Can_Add_Money()
        {

            // Arrange
            var m1 = new Money(10m, "usd");
            var m2 = new Money(12.1m, "usd");
            var m3 = m1 + m2;

            var expected = 22.1m;

            // Act
            var actual = m3;

            // Assert
            Assert.AreEqual(expected, actual.Amount);
            Assert.AreEqual("usd", actual.Currency);

        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Money_Throws_If_Adding_Different_Currencies()
        {

            // Arrange
            var m1 = new Money(10m, "usd");
            var m2 = new Money(12.1m, "nok");
            var m3 = m1 + m2;

             

            // Act
            

            // Assert
             

        }
    }



}
