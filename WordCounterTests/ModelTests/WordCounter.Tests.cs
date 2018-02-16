using Microsoft.VisualStudio.TestTools.UnitTesting;
using RepeatCounter.Models;
using System;

namespace RepeatCounter.TestTools
{
    [TestClass]
    public class RepeatCounterTest
    {
        [TestMethod]
        public void GetStrings_TestInput_String()
        {
            //arrange
            string testPhrase = "This phrase is an input phrase from the user.";
            string testCheck = "phrase";
            RepeatCounterCreator newRepeatCounterCreator = new RepeatCounterCreator("This phrase is an input phrase from the user.", "phrase");

            //act
            string targetPhrase = newRepeatCounterCreator.GetPhrase();
            string targetCheck = newRepeatCounterCreator.Getcheck();

            //assert
            Assert.AreEqual(testPhrase, targetPhrase);
            Assert.AreEqual(testCheck, targetCheck);
        }
    }
}
