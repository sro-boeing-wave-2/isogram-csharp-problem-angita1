using System;
using Xunit;
using isogram;


  //- Should hold true for empty string ``
  //- Should hold true for word `isogram` with lower case characters
  //- Should hold false for word `eleven`
  //- Should hold true for long reported english word like `subdermatoglyphic`
  //- Should hold true for word with duplicated character in mixed case `Alphabet`
  //- Should hold true for word with hyphen `thumbscrew-japingly`
  //- Should hold true for word with duplicated hyphen `six-year-old`
  //- Should hold true for name which is seperated by spaces

namespace isogram.Tests
{
    public class IsogramTests
    {
        [Fact]
        public void emptyString()
        {
            Assert.True(Isogram.IsIsogram(""));
        }

        [Fact]
        public void isogram()
        {
            Assert.True(Isogram.IsIsogram("isogram"));
        }

        [Fact]
        public void eleven()
        {
            Assert.False(Isogram.IsIsogram("eleven"));
        }

        [Fact]
        public void longWord()
        {
            Assert.True(Isogram.IsIsogram("subdermatoglyphic"));
        }

        [Fact]
        public void upperAndLower()
        {
            Assert.True(Isogram.IsIsogram("Alphabet"));
        }

        [Fact]
        public void thumbScrew()
        {
            Assert.True(Isogram.IsIsogram("thumbscrew-japingly"));
        }

        [Fact]
        public void hyphen()
        {
            Assert.True(Isogram.IsIsogram("six-year-old"));
        }

        [Fact]
        public void spaceName()
        {
            Assert.True(Isogram.IsIsogram("Angit Devy"));
        }

    }
}
