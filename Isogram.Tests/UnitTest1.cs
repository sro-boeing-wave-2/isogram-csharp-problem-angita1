using System;
using Xunit;

namespace Isogram.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void emptyString()
        {
            Assert.True(Class1.IsIsogram(""));
        }

        [Fact]
        public void isogram()
        {
            Assert.True(Class1.IsIsogram("isogram"));
        }

        [Fact]
        public void eleven()
        {
            Assert.False(Class1.IsIsogram("eleven"));
        }

        [Fact]
        public void longWord()
        {
            Assert.True(Class1.IsIsogram("subdermatoglyphic"));
        }

        [Fact]
        public void upperAndLower()
        {
            Assert.True(Class1.IsIsogram("Alphabet"));
        }

        [Fact]
        public void thumbScrew()
        {
            Assert.True(Class1.IsIsogram("thumbscrew-japingly"));
        }

        [Fact]
        public void hyphen()
        {
            Assert.True(Class1.IsIsogram("six-year-old"));
        }

        [Fact]
        public void spaceName()
        {
            Assert.True(Class1.IsIsogram("Angit Devy"));
        }
    }
}
