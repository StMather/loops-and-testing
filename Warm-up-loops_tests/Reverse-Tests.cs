using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Warm_up_loops;

namespace Warm_up_loops_tests
{
    [TestClass]
    public class Reverse_Tests
    {
        [TestMethod]
        public void InputEven()
        {
            string inPut = "to";
            String expected = "ot";
            string outPut = "";
            var thing = new Reverser();

            outPut = thing.Reverse(inPut);

            Assert.AreEqual(expected, outPut);
        }
        [TestMethod]
        public void InputOdd()
        {
            string inPut = "hello";
            String expected = "olleh";
            string outPut = "";
            var thing = new Reverser();

            outPut = thing.Reverse(inPut);

            Assert.AreEqual(expected, outPut);
        }
        
    }
}
