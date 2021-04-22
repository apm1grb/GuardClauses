using Ardalis.GuardClauses;
using System;
using Xunit;

namespace GuardClauses.UnitTests
{
    public class GuardAgainstZero
    {
        [Fact]
        public void DoesNothingGivenNonZeroValue()
        {
            Guard.Against.Zero(-1, "minusOne");
            Guard.Against.Zero(1, "plusOne");
            Guard.Against.Zero(int.MinValue, "int.MinValue");
            Guard.Against.Zero(int.MaxValue, "int.MaxValue");
            Guard.Against.Zero(long.MinValue, "long.MinValue");
            Guard.Against.Zero(long.MaxValue, "long.MaxValue");
            Guard.Against.Zero(decimal.MinValue, "decimal.MinValue");
            Guard.Against.Zero(decimal.MaxValue, "decimal.MaxValue");
            Guard.Against.Zero(float.MinValue, "float.MinValue");
            Guard.Against.Zero(float.MaxValue, "float.MaxValue");
            Guard.Against.Zero(double.MinValue, "double.MinValue");
            Guard.Against.Zero(double.MaxValue, "double.MaxValue");
        }

        [Fact]
        public void ThrowsGivenZeroValueIntZero()
        {
            Assert.Throws<ArgumentException>(() => Guard.Against.Zero(0, "zero"));
        }

        [Fact]
        public void ThrowsSelfOwnErrorMessageGivenZeroValueIntZero()
        {
            var exception = Assert.Throws<ArgumentException>(() => Guard.Against.Zero(0, "zero", "selfOwnErrorMessage"));
            Assert.Contains("selfOwnErrorMessage", exception.Message);
        }

        [Fact]
        public void ThrowsGivenZeroValueLongZero()
        {
            Assert.Throws<ArgumentException>(() => Guard.Against.Zero(0L, "zero"));
        }

        [Fact]
        public void ThrowsSelfOwnErrorMessageGivenZeroValueLongZero()
        {
            var exception = Assert.Throws<ArgumentException>(() => Guard.Against.Zero(0L, "zero", "selfOwnErrorMessage"));
            Assert.Contains("selfOwnErrorMessage", exception.Message);
        }

        [Fact]
        public void ThrowsGivenZeroValueDecimalZero()
        {
            Assert.Throws<ArgumentException>(() => Guard.Against.Zero(0.0M, "zero"));
        }

        [Fact]
        public void ThrowsSelfOwnErrorMessageGivenZeroValueDecimalZero()
        {
            var exception = Assert.Throws<ArgumentException>(() => Guard.Against.Zero(0.0M, "zero", "selfOwnErrorMessage"));
            Assert.Contains("selfOwnErrorMessage", exception.Message);
        }

        [Fact]
        public void ThrowsGivenZeroValueFloatZero()
        {
            Assert.Throws<ArgumentException>(() => Guard.Against.Zero(0.0f, "zero"));
        }

        [Fact]
        public void ThrowsSelfOwnErrorMessageGivenZeroValueFloatZero()
        {
            var exception = Assert.Throws<ArgumentException>(() => Guard.Against.Zero(0.0f, "zero", "selfOwnErrorMessage"));
            Assert.Contains("selfOwnErrorMessage", exception.Message);
        }

        [Fact]
        public void ThrowsGivenZeroValueDoubleZero()
        {
            Assert.Throws<ArgumentException>(() => Guard.Against.Zero(0.0, "zero"));
        }

        [Fact]
        public void ThrowsSelfOwnErrorMessageGivenZeroValueDoubleZero()
        {
            var exception = Assert.Throws<ArgumentException>(() => Guard.Against.Zero(0.0, "zero", "selfOwnErrorMessage"));
            Assert.Contains("selfOwnErrorMessage", exception.Message);
        }

        [Fact]
        public void ThrowsGivenZeroValueDefaultInt()
        {
            Assert.Throws<ArgumentException>(() => Guard.Against.Zero(default(int), "zero"));
        }

        [Fact]
        public void ThrowsSelfOwnErrorMessageGivenZeroValueDefaultInt()
        {
            var exception = Assert.Throws<ArgumentException>(() => Guard.Against.Zero(default(int), "zero", "selfOwnErrorMessage"));
            Assert.Contains("selfOwnErrorMessage", exception.Message);
        }

        [Fact]
        public void ThrowsGivenZeroValueDefaultLong()
        {
            Assert.Throws<ArgumentException>(() => Guard.Against.Zero(default(long), "zero"));
        }

        [Fact]
        public void ThrowsSelfOwnErrorMessageGivenZeroValueDefaultLong()
        {
            var exception = Assert.Throws<ArgumentException>(() => Guard.Against.Zero(default(long), "zero", "selfOwnErrorMessage"));
            Assert.Contains("selfOwnErrorMessage", exception.Message);
        }

        [Fact]
        public void ThrowsGivenZeroValueDefaultDecimal()
        {
            Assert.Throws<ArgumentException>(() => Guard.Against.Zero(default(decimal), "zero"));
        }

        [Fact]
        public void ThrowsSelfOwnErrorMessageGivenZeroValueDefaultDecimal()
        {
            var exception = Assert.Throws<ArgumentException>(() => Guard.Against.Zero(default(decimal), "zero", "selfOwnErrorMessage"));
            Assert.Contains("selfOwnErrorMessage", exception.Message);
        }

        [Fact]
        public void ThrowsGivenZeroValueDefaultFloat()
        {
            Assert.Throws<ArgumentException>(() => Guard.Against.Zero(default(float), "zero"));
        }

        [Fact]
        public void ThrowsSelfOwnErrorMessageGivenZeroValueDefaultFloat()
        {
            var exception = Assert.Throws<ArgumentException>(() => Guard.Against.Zero(default(float), "zero", "selfOwnErrorMessage"));
            Assert.Contains("selfOwnErrorMessage", exception.Message);
        }

        [Fact]
        public void ThrowsGivenZeroValueDefaultDouble()
        {
            Assert.Throws<ArgumentException>(() => Guard.Against.Zero(default(double), "zero"));
        }

        [Fact]
        public void ThrowsSelfOwnErrorMessageGivenZeroValueDefaultDouble()
        {
            var exception = Assert.Throws<ArgumentException>(() => Guard.Against.Zero(default(double), "zero", "selfOwnErrorMessage"));
            Assert.Contains("selfOwnErrorMessage", exception.Message);
        }

        [Fact]
        public void ThrowsGivenZeroValueDecimalDotZero()
        {
            Assert.Throws<ArgumentException>(() => Guard.Against.Zero(decimal.Zero, "zero"));
        }

        [Fact]
        public void ThrowsSelfOwnErrorMessageGivenZeroValueDecimalDotZero()
        {
            var exception = Assert.Throws<ArgumentException>(() => Guard.Against.Zero(decimal.Zero, "zero", "selfOwnErrorMessage"));
            Assert.Contains("selfOwnErrorMessage", exception.Message);
        }

        [Fact]
        public void ReturnsExpectedValueWhenGivenNonZeroValue()
        {
            Assert.Equal(-1, Guard.Against.Zero(-1, "minusOne"));
            Assert.Equal(1, Guard.Against.Zero(1, "plusOne"));
            Assert.Equal(int.MinValue, Guard.Against.Zero(int.MinValue, "int.MinValue"));
            Assert.Equal(int.MaxValue, Guard.Against.Zero(int.MaxValue, "int.MaxValue"));
            Assert.Equal(long.MinValue, Guard.Against.Zero(long.MinValue, "long.MinValue"));
            Assert.Equal(long.MaxValue, Guard.Against.Zero(long.MaxValue, "long.MaxValue"));
            Assert.Equal(decimal.MinValue, Guard.Against.Zero(decimal.MinValue, "decimal.MinValue"));
            Assert.Equal(decimal.MaxValue, Guard.Against.Zero(decimal.MaxValue, "decimal.MaxValue"));
            Assert.Equal(float.MinValue, Guard.Against.Zero(float.MinValue, "float.MinValue"));
            Assert.Equal(float.MaxValue, Guard.Against.Zero(float.MaxValue, "float.MaxValue"));
            Assert.Equal(double.MinValue, Guard.Against.Zero(double.MinValue, "double.MinValue"));
            Assert.Equal(double.MaxValue, Guard.Against.Zero(double.MaxValue, "double.MaxValue"));
        }
    }
}
