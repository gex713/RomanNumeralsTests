using DoRomanNumerals;
using FluentAssertions;
using System;
using Xunit;

namespace RomanNumeralsTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1, "I")]
        [InlineData(2, "II")]
        [InlineData(3, "III")]
        [InlineData(4, "IV")]
        [InlineData(5, "V")]
        [InlineData(6, "VI")]
        [InlineData(7, "VII")]
        [InlineData(8, "VIII")]
        public void Test1(int arabic, string expected)
        {
            var runner = new ConvertArabicToRoman();

            runner.Convert(arabic).Should().Be(expected);
        }
    }
}
