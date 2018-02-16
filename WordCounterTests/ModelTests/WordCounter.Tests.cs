using Microsoft.VisualStudio.TestTools.UnitTesting;
using RepeatCounter.Models;
using System.Collections;
using System.Collections.Generic;
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
            string targetCheck = newRepeatCounterCreator.GetCheck();

            //assert
            Assert.AreEqual(testPhrase, targetPhrase);
            Assert.AreEqual(testCheck, targetCheck);
        }

        [TestMethod]
        public void CountStringOccurences_TestMethod_Int()
        {
            //Arrange
            string testPhrase = "This phrase is an input phrase from the user.";
            string testCheck = "phrase";
            RepeatCounterCreator newRepeatCounterCreator = new RepeatCounterCreator("This phrase is an input phrase from the user.", "phrase");

            //Act
            int target = RepeatCounterCreator.CountTool.CountStringOccurences(testPhrase, testCheck);

            //Assert
            Assert.AreEqual(target, 2);

        }

    }
}
