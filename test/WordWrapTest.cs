using System;
using NUnit.Framework;
using Chaiwatmat.WordWrap;

namespace Chaiwatmat.WordWrap.Test
{
    [TestFixture]
    public class WordWrapTest
    {
        private WordWrap _wordWrap;

        public WordWrapTest(){
            _wordWrap = new WordWrap();
        }

        [TestCase("Hello", 4, "Hell...")]
        [TestCase("Hello", 10, "Hello")]
        public void TestWrapString_ShouldCorrect(string text, int length, string expected){
            var result = _wordWrap.Wrap(text, length);
            Assert.AreEqual(expected, result);
        }
    }
}
