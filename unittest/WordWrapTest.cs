using System;
using Xunit;
using Chaiwatmat.WordWrap;

namespace Chaiwatmat.WordWrap.Test
{
    public class WordWrapTest
    {
        private WordWrap _wordWrap;

        public WordWrapTest(){
            _wordWrap = new WordWrap();
        }

        [Theory]
        [InlineData("Hello", 4, "Hell...")]
        [InlineData("Hello", 10, "Hello")]
        public void TestWrapString_ShouldCorrect(string text, int length, string expected){
            var result = _wordWrap.Wrap(text, length);
            Assert.Equal(expected, result);
        }
    }
}
