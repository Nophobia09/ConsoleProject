namespace MSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow(2, 2, 4)]
        [DataRow(-200, -300, -500)]
        [DataRow(int.MaxValue - 500, 250, int.MaxValue - 250)]
        public void TestAdd(int a, int b, int expected)
        {
            // Arrange
            ConsoleProject.BasicMethods basic = new ConsoleProject.BasicMethods();
            
            // Act
            int result = basic.Add(a, b);
            
            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow("test", "tset")]
        [DataRow("car", "rac")]
        [DataRow("racecar", "racecar")]
        public void TestReverseString(string input, string expected)
        {
            // Arrange
            ConsoleProject.BasicMethods basic = new ConsoleProject.BasicMethods();
            
            // Act
            string result = basic.ReverseString(input);
            
            // Assert
            Assert.AreEqual(expected, result);
        }
        
        [TestMethod]
        [DataRow("test", false)]
        [DataRow("car", false)]
        [DataRow("racecar", true)]
        public void TestIsPalindrome(string input, bool expected)
        {
            // Arrange
            ConsoleProject.BasicMethods basic = new ConsoleProject.BasicMethods();
            
            // Act
            bool result = basic.IsPalindrome(input);
            
            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(4,2,2)]
        [DataRow(2,2,1)]
        [DataRow(2,0,0)]
        public void TestDivide(int a, int b, Double expected)
        {
            // Arrange
            ConsoleProject.IntermediateMethods intermediate = new ConsoleProject.IntermediateMethods();
            
            // Act
            Double result = intermediate.Divide(a, b);
            
            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(0, 20, 10)]
        [DataRow(200, 1000, 600)]
        [DataRow(10,20,15)]
        public void TestMiddle(int first, int second, int expected)
        {
            //Arrange
            ConsoleProject.IntermediateMethods intermediate = new ConsoleProject.IntermediateMethods();
            //Act
            int result = intermediate.Middle(first, second);
            //Assert
            Assert.AreEqual(expected, result);
        }
        
        [TestMethod]
        [DataRow("john@yahoo.com", true)]
        [DataRow("1@hotmail.com", true)]
        [DataRow("1@.com", false)]
        [DataRow("@.gmail.com", false)]
        public void TestValidateEmail(string email, bool expected)
        {
            //Arrange
            ConsoleProject.AdvancedMethods advanced = new ConsoleProject.AdvancedMethods();
            //Act
            bool result = advanced.ValidateEmail(email);
            //Assert
            Assert.AreEqual(expected, result);
        }
        
        [TestMethod]
        [DataRow("car", 2, "ect")]
        [DataRow("snow", 5, "xstb")]
        [DataRow("cool", 125, "xjjg")]
        public void TestEncryptString(string input, int shift, string expected)
        {
            //Arrange
            ConsoleProject.AdvancedMethods advanced = new ConsoleProject.AdvancedMethods();
            //Act
            string result = advanced.EncryptString(input, shift);
            //Assert
            Assert.AreEqual(expected, result);
        }
        
        [TestMethod]
        [DataRow(0, 0)]
        [DataRow(int.MaxValue, int.MaxValue)]
        [DataRow(1, 1)]
        public void TestOneWillThrowException(int value, int expected)
        {
            //Arrange
            ConsoleProject.AdvancedMethods advanced = new ConsoleProject.AdvancedMethods();
            //Act
            int result = advanced.OneWillThrowException(value);
            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}