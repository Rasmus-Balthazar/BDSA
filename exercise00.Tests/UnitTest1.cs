using System;
using Xunit;
using System.IO;


namespace exercise00.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

        [Theory]
        [InlineData(4)]
        [InlineData(16)]
        [InlineData(20)]
        public void Year_DivisableBy4_ReturnTrue(int value)
        {
            bool expected = true;
            var actual = Program.IsLeapYear(value);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(13)]
        [InlineData(17)]
        public void Year_NotDivisableBy4_ReturnFalse(int value)
        {
            bool expected = false;
            var actual = Program.IsLeapYear(value);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(400)]
        [InlineData(1600)]
        [InlineData(2000)]
        public void Year_DivisableBy400_ReturnFalse(int value)
        {
            bool expected = true;
            var actual = Program.IsLeapYear(value);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1300)]
        [InlineData(600)]
        [InlineData(300)]
        public void Year_DivisableBy100_Not400_ReturnFalse(int value){
            bool expected = false;
            var actual = Program.IsLeapYear(value);
            Assert.Equal(expected, actual);
        }
    }
}
