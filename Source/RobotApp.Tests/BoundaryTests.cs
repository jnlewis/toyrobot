using RobotApp.Application.Boundaries;
using RobotApp.Domain.ValueObjects;
using Xunit;

namespace RobotApp.Tests
{
    public class BoundaryTests
    {
        [Fact]
        public void SquareBoundary_WithinBounds_ReturnsTrue()
        {
            // Arrange
            var boundary = new SquareBoundary(5);

            // Act
            var isWithinBoundary = boundary.IsWithinBoundary(new Position(4, 4));

            // Assert
            Assert.True(isWithinBoundary);
        }

        [Fact]
        public void SquareBoundary_ExceedTopBounds_ReturnsFalse()
        {
            // Arrange
            var boundary = new SquareBoundary(5);

            // Act
            var isWithinBoundary = boundary.IsWithinBoundary(new Position(5, 0));

            // Assert
            Assert.False(isWithinBoundary);
        }

        [Fact]
        public void SquareBoundary_ExceedRightBounds_ReturnsFalse()
        {
            // Arrange
            var boundary = new SquareBoundary(5);

            // Act
            var isWithinBoundary = boundary.IsWithinBoundary(new Position(0, 5));

            // Assert
            Assert.False(isWithinBoundary);
        }

        [Fact]
        public void SquareBoundary_ExceedBottomBounds_ReturnsFalse()
        {
            // Arrange
            var boundary = new SquareBoundary(5);

            // Act
            var isWithinBoundary = boundary.IsWithinBoundary(new Position(-1, 0));

            // Assert
            Assert.False(isWithinBoundary);
        }

        [Fact]
        public void SquareBoundary_ExceedLeftBounds_ReturnsFalse()
        {
            // Arrange
            var boundary = new SquareBoundary(5);

            // Act
            var isWithinBoundary = boundary.IsWithinBoundary(new Position(0, -1));

            // Assert
            Assert.False(isWithinBoundary);
        }
    }
}
