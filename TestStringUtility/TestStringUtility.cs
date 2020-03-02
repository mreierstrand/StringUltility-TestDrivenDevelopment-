using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringUltility;

namespace TestStringUtility
{
    [TestClass]
    public class TestStringUtility
    {
        [TestMethod]
        public void FindcharInZealand()
        {
            string stringToCheck = "Zealand";
            string findLetter = "l";
            int expectedResult = 1;

            StringUltility.StringUtility ClassToTest = new StringUtility();
            int actualResult = ClassToTest.CountOcurrences(stringToCheck, findLetter);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void FindMultipleCharsInZealand()
        {
            string stringToCheck = "Zealand";
            string findLetter = "a";
            int expectedResult = 2;

            StringUltility.StringUtility ClassToTest = new StringUtility();
            int actualResult = ClassToTest.CountOcurrences(stringToCheck, findLetter);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void NoCaseSensitivity()
        {
            string stringToCheck = "Zealand";
            string findLetter = "z";
            int expectedResult = 1;


            StringUltility.StringUtility classToTest = new StringUtility();
            int actualResult = classToTest.CountOcurrences(stringToCheck, findLetter);
            Assert.AreEqual(expectedResult, actualResult);
        }


    }
}
