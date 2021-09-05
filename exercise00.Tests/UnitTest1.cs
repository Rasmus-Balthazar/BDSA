using System;
using Xunit;
using System.IO;


namespace exercise00.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1584)]
        [InlineData(1592)]
        [InlineData(1604)]
        public void Year_DivisableBy4_ReturnTrue(int value)
        {
            bool expected = true;
            var actual = Program.IsLeapYear(value);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1582)]
        [InlineData(1591)]
        public void Year_NotDivisableBy4_ReturnFalse(int value)
        {
            bool expected = false;
            var actual = Program.IsLeapYear(value);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2400)]
        [InlineData(1600)]
        [InlineData(2000)]
        public void Year_DivisableBy400_ReturnFalse(int value)
        {
            bool expected = true;
            var actual = Program.IsLeapYear(value);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1700)]
        [InlineData(1800)]
        [InlineData(2100)]
        public void Year_DivisableBy100_Not400_ReturnFalse(int value){
            bool expected = false;
            var actual = Program.IsLeapYear(value);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Main_IsGregorianYear_Print_Yay()
        {
            var writer = new StringWriter();
            Console.SetOut(writer);
            var reader = new StringReader("1600");
            Console.SetIn(reader);
            Program.Main(new string[0]);
        
            string actual = writer.GetStringBuilder().ToString().Trim();
            
            Assert.Equal("yay", actual);
        }

        [Fact]
        public void Main_NotGregorianYear_Print_Nay()
        {

            var writer = new StringWriter();
            var reader = new StringReader("1599");
            Console.SetIn(reader);
            Console.SetOut(writer);
            Program.Main(new string[0]);
            
            string actual = writer.GetStringBuilder().ToString().Trim();
            
            Assert.Equal("nay", actual);
        }

        [Fact]
        public void Main_Input_NaN()
        {
            var writer = new StringWriter();
            var reader = new StringReader("four");
            Console.SetIn(reader);
            Console.SetOut(writer);
            Program.Main(new string[0]);
            
            string actual = writer.GetStringBuilder().ToString().Trim();
            
            Assert.Equal("NaN", actual);
        }

        [Theory]
        [InlineData(1581)]
        [InlineData(0)]
        public void Year_Below_1582(int value)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Program.IsLeapYear(value));
        }

    }
}
