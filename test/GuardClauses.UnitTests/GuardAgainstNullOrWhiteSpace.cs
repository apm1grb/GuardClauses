﻿using Ardalis.GuardClauses;
using System;
using Xunit;

namespace GuardClauses.UnitTests
{
    public class GuardAgainstNullOrWhiteSpace
    {
        [Theory]
        [InlineData("a")]
        [InlineData("1")]
        [InlineData("some text")]
        [InlineData(" leading whitespace")]
        [InlineData("trailing whitespace ")]
        public void DoesNothingGivenNonEmptyStringValue(string nonEmptyString)
        {
            Guard.Against.NullOrWhiteSpace(nonEmptyString, "string");
            Guard.Against.NullOrWhiteSpace(nonEmptyString, "aNumericString");
        }

        [Fact]
        public void ThrowsGivenNullValue()
        {
            Assert.Throws<ArgumentNullException>(() => Guard.Against.NullOrWhiteSpace(null, "null"));
        }

        [Fact]
        public void ThrowsSelfOwnErrorMessageGivenNullValue()
        {
            var exception = Assert.Throws<ArgumentNullException>(() =>
                Guard.Against.NullOrWhiteSpace(null, "null", "selfOwnErrorMessage"));
            Assert.Contains("selfOwnErrorMessage", exception.Message);
        }

        [Fact]
        public void ThrowsGivenEmptyString()
        {
            Assert.Throws<ArgumentException>(() => Guard.Against.NullOrWhiteSpace("", "emptystring"));
        }

        [Fact]
        public void ThrowsSelfOwnErrorMessageGivenEmptyString()
        {
            var exception = Assert.Throws<ArgumentException>(() =>
                Guard.Against.NullOrWhiteSpace("", "emptystring", "selfOwnErrorMessage"));
            Assert.Contains("selfOwnErrorMessage", exception.Message);
        }

        [Theory]
        [InlineData(" ")]
        [InlineData("   ")]
        public void ThrowsGivenWhiteSpaceString(string whiteSpaceString)
        {
            Assert.Throws<ArgumentException>(() =>
                Guard.Against.NullOrWhiteSpace(whiteSpaceString, "whitespacestring"));
        }

        [Theory]
        [InlineData(" ")]
        [InlineData("   ")]
        public void ThrowsSelfOwnErrorMessageGivenWhiteSpaceString(string whiteSpaceString)
        {
            var exception = Assert.Throws<ArgumentException>(() =>
                Guard.Against.NullOrWhiteSpace(whiteSpaceString, "whitespacestring", "selfOwnErrorMessage"));
            Assert.Contains("selfOwnErrorMessage", exception.Message);
        }

        [Theory]
        [InlineData("a", "a")]
        [InlineData("1", "1")]
        [InlineData("some text", "some text")]
        [InlineData(" leading whitespace", " leading whitespace")]
        [InlineData("trailing whitespace ", "trailing whitespace ")]
        public void ReturnsExpectedValueGivenNonEmptyStringValue(string nonEmptyString, string expected)
        {
            Assert.Equal(expected, Guard.Against.NullOrWhiteSpace(nonEmptyString, "string"));
            Assert.Equal(expected, Guard.Against.NullOrWhiteSpace(nonEmptyString, "aNumericString"));
        }

    }
}
