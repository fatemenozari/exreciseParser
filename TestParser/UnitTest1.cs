using FluentAssertions;
using Xunit;
using ExreciseParser;
using System.Linq;
using System;

namespace TestParser
{
    public class ParserTest
    {

        [Fact]
        public void Should_Return_String_Array()
        {
            var Word = "red, green, blue";
            var separator = ",";

            var result = Parser.Parse(Word, separator);

            Assert.IsType<string[]>(result);

        }

        [Fact]
        public void Should_Return_Exception_When_Separator_Is_EmptyOrNull()
        {
            string Word = "red, green, blue";
            string separator ="";

            var result =() => Parser.Parse(Word, separator);

            result.Should().Throw<Exception>();
            
        }

        [Fact]
        public void Should_Return_Empty_Array_When_Word_Is_EmptyOrNull()
        {
            string Word = null;
            string separator = ",";

            var result = Parser.Parse(Word, separator);

            result.Should().BeEmpty();

        }
    }
}