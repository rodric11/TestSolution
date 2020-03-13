using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            int a = 12;

            if (a % 2 == 0)
            {
                Console.WriteLine("делится на 2");
            }

            if (a % 3 == 0)
            {
                Console.WriteLine("делится на 3");
            }

            if (a % 5 == 0)
            {
                Console.WriteLine("делится на 5");
            }
        }
    }
}
