using Ardalis.GuardClauses;
using System;
using System.Linq;
using Xunit;

namespace GuardClauses.UnitTests
{
    public class GuardAgainstNullOrEmpty
    {
        [Fact]
        public void DoesNothingGivenNonEmptyStringValue()
        {
            Guard.Against.NullOrEmpty("a", "string");
            Guard.Against.NullOrEmpty("1", "aNumericString");
        }

        [Fact]
        public void DoesNothingGivenNonEmptyGuidValue()
        {
            Guard.Against.NullOrEmpty(Guid.NewGuid(), "guid");
        }

        [Fact]
        public void DoesNothingGivenNonEmptyEnumerable()
        {
            Guard.Against.NullOrEmpty(new [] { "foo", "bar" }, "stringArray");
            Guard.Against.NullOrEmpty(new [] { 1, 2 }, "intArray");
        }

        [Fact]
        public void ThrowsGivenNullString()
        {
            string? nullString = null;
            Assert.Throws<ArgumentNullException>(() => Guard.Against.NullOrEmpty(nullString, "nullString"));
        }

        [Fact]
        public void ThrowsGivenEmptyString()
        {
            Assert.Throws<ArgumentException>(() => Guard.Against.NullOrEmpty("", "emptyString"));
        }
        [Fact]
        public void ThrowsSelfOwnErrorMessageGivenEmptyString()
        {
            var ex = Assert.Throws<ArgumentException>(() => Guard.Against.NullOrEmpty("", "emptyString", "selfOwnErrorMessage"));
            Assert.Contains("selfOwnErrorMessage", ex.Message);
        }

        [Fact]
        public void ThrowsGivenNullGuid()
        {
            Guid? nullGuid = null;
            Assert.Throws<ArgumentNullException>(() => Guard.Against.NullOrEmpty(nullGuid, "nullGuid"));
        }
        [Fact]
        public void ThrowsSelfOwnErrorMessageGivenNullGuid()
        {
            Guid? nullGuid = null;
            var ex = Assert.Throws<ArgumentNullException>(() => Guard.Against.NullOrEmpty(nullGuid, "nullGuid", "selfOwnErrorMessage"));
            Assert.Contains("selfOwnErrorMessage", ex.Message);
        }

        [Fact]
        public void ThrowsGivenEmptyGuid()
        {
            Assert.Throws<ArgumentException>(() => Guard.Against.NullOrEmpty(Guid.Empty, "emptyGuid"));
        }
        [Fact]
        public void ThrowsSelfOwnErrorMessageGivenEmptyGuid()
        {
            var ex = Assert.Throws<ArgumentException>(() => Guard.Against.NullOrEmpty(Guid.Empty, "emptyGuid", "selfOwnErrorMessage"));
            Assert.Contains("selfOwnErrorMessage", ex.Message);
        }

        [Fact]
        public void ThrowsGivenEmptyEnumerable()
        {
            Assert.Throws<ArgumentException>(() => Guard.Against.NullOrEmpty(Enumerable.Empty<string>(), "emptyStringEnumerable"));
        }
        [Fact]
        public void ThrowsSelfOwnErrorMessageGivenEmptyEnumerable()
        {
            var ex = Assert.Throws<ArgumentException>(() => Guard.Against.NullOrEmpty(Enumerable.Empty<string>(), "emptyStringEnumerable", "selfOwnErrorMessage"));
            Assert.Contains("selfOwnErrorMessage", ex.Message);
        }

        [Fact]
        public void ReturnsExpectedValueWhenGivenValidValue()
        {
            Assert.Equal("a", Guard.Against.NullOrEmpty("a", "string"));
            Assert.Equal("1", Guard.Against.NullOrEmpty("1", "aNumericString"));

            var collection1 = new[] {"foo", "bar"};
            Assert.Equal(collection1, Guard.Against.NullOrEmpty(collection1, "stringArray"));

            var collection2 = new[] {1, 2};
            Assert.Equal(collection2, Guard.Against.NullOrEmpty(collection2, "intArray"));
        }

    }
}
