using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SymbolCounter;

namespace UnitTest_SymbolCount
{
    [TestClass]
    public class SymbolCountTest
    {
        [TestMethod]
        public void SymbolCounter1()
        {
            //arrange
            string source = "AAA0000";
            char findSymbol = 'A';
            int expected = 3;

            //act
            Program counter = new Program();
            int actual = counter.SymbolCount(findSymbol, source);

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SymbolCounter2()
        {
            //arrange
            string source = "dklfAaaaaaaaaaaaaaaaaaaaaaa123456A";
            char findSymbol = 'A';
            int expected = 2;

            //act
            Program counter = new Program();
            int actual = counter.SymbolCount(findSymbol, source);

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SymbolCounter3()
        {
            //arrange
            string source = "545458945dfdsf&*^@*&%^@^&%@%^&*                 458490-9ffdf-0";
            char findSymbol = 'A';
            int expected = 0;

            //act
            Program counter = new Program();
            int actual = counter.SymbolCount(findSymbol, source);

            //assert
            Assert.AreEqual(expected, actual);
        }

    }
}
