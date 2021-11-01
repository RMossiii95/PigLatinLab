using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace PigLatin
{
    public class Testing
    {
        [Fact]
        public void TestWord()
        {
            TestPigLatin test = new TestPigLatin();
            string actual = test.ToPigLatin("apple");
            Assert.Equal("appleway", actual);
        }
        [Theory]
        [InlineData("apple", "appleway")]
        [InlineData("heck", "eckhay")]
        [InlineData("strong", "ongstray")]
        [InlineData("tommy@email.com", "tommy@email.com")]
        [InlineData("aardvark", "aardvarkway")]
        [InlineData("Tommy", "ommytay")]
        [InlineData("gym", "gym")]
        [InlineData("apple joy gym tommy@email.com strong", "appleway oyjay gym tommy@email.com ongstray")]
        public void Test(string input, string expected)
        {
            TestPigLatin test = new TestPigLatin();
            string actual = test.ToPigLatin(input);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestVowel()
        {
            TestPigLatin test = new TestPigLatin();
            bool expected = true;
            bool actual = test.IsVowel('a');
            Assert.Equal(expected, actual);
        }
    }
}