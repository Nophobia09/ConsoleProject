using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using System.Security.Cryptography.X509Certificates;

namespace MSTest
{
    [TestClass]
    public class UnitTest1
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        //Basic.Add()
        [DataRow(2,2,4)]
        [DataRow(-200,-300,-500)]
        [DataRow(int.MaxValue-500,250,int.MaxValue-250)]
        //Basic.ReverseString()
        [DataRow("test","tset")]
        [DataRow("car", "rac")]
        [DataRow("racecar","racecar")]
        public void TestStuff(int a, int b, string input, object expected, object result)
        {
            //Basic.Add()
            //Arrange
            ConsoleProject.BasicMethods basic = new ConsoleProject.BasicMethods();
            //Act            
            if(DataRowAttribute. == int) //Test ints
            {   //Act
                result = basic.Add((int)a,(int)b);
                //Assert
                Assert.AreEqual(expected, result);
            }else if(a.GetType() == typeof(string))
            {
                //Basic.ReverseString()
                //Arrange Up Above
                //Act
                result = basic.ReverseString((string)a);
                //Assert
                Assert.AreEqual(expected, result);       
            }
            

           
            

        }
    }
}