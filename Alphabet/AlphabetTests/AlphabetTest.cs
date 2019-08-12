using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlphabetLib;


namespace AlphabetTests
{
    [TestClass]
    public class AlphabetTest
    {
        [TestMethod]
        public void TestLetter_T()
        {
            var a = 'T';
            var result = Alphabet.AllLettersAfter(a);
            Assert.AreEqual("UVWXYZ", result);
        }

        [TestMethod]
        public void TestLetter_b()
        {
            var a = 'b';
            var result = Alphabet.AllLettersAfter(a);
            Assert.AreEqual("CDEFGHIJKLMNOPQRSTUVWXYZ", result);
        }

        [TestMethod]
        public void TestLetter_g()
        {
            var a = 'g';
            var result = Alphabet.AllLettersAfter(a);
            Assert.AreEqual("HIJKLMNOPQRSTUVWXYZ", result);
        }

        [TestMethod]
        public void TestLetter_z()
        {
            var a = 'z';
            var result = Alphabet.AllLettersAfter(a);
            Assert.AreEqual("Это последняя буква алфавита!", result);
        }

        [TestMethod]
        public void TestLetter_1()
        {
            var a = '1';
            var result = Alphabet.AllLettersAfter(a);
            Assert.AreEqual("Введите букву английского алфавита!", result);
        }

        [TestMethod]
        public void TestRussionLetter()
        {
            var a = 'Я';
            var result = Alphabet.AllLettersAfter(a);
            Assert.AreEqual("Введите букву английского алфавита!", result);
        }
    }
}
