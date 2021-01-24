using RobotApp.Application.Boundaries;
using RobotApp.Application.Toys;
using RobotApp.Domain.ValueObjects;
using Xunit;

namespace RobotApp.Tests
{
    public class ToyTests
    {
        [Fact]
        public void ToyRobot_CanMoveNorth()
        {
            // Arrange
            var boundary = new SquareBoundary(5);
            var toy = Toy.CreateToyRobot(boundary, new Position(0, 0), Directions.North);

            // Act
            toy.Move();

            // Assert
            var position = toy.GetPosition();
            Assert.Equal(0, position.X);
            Assert.Equal(1, position.Y);
        }

        [Fact]
        public void ToyRobot_CanMoveSouth()
        {
            // Arrange
            var boundary = new SquareBoundary(5);
            var toy = Toy.CreateToyRobot(boundary, new Position(0, 1), Directions.South);

            // Act
            toy.Move();

            // Assert
            var position = toy.GetPosition();
            Assert.Equal(0, position.X);
            Assert.Equal(0, position.Y);
        }

        [Fact]
        public void ToyRobot_CanMoveEast()
        {
            // Arrange
            var boundary = new SquareBoundary(5);
            var toy = Toy.CreateToyRobot(boundary, new Position(0, 0), Directions.East);

            // Act
            toy.Move();

            // Assert
            var position = toy.GetPosition();
            Assert.Equal(1, position.X);
            Assert.Equal(0, position.Y);
        }

        [Fact]
        public void ToyRobot_CanMoveWest()
        {
            // Arrange
            var boundary = new SquareBoundary(5);
            var toy = Toy.CreateToyRobot(boundary, new Position(1, 0), Directions.West);

            // Act
            toy.Move();

            // Assert
            var position = toy.GetPosition();
            Assert.Equal(0, position.X);
            Assert.Equal(0, position.Y);
        }

        [Fact]
        public void ToyRobot_CanRotateRight()
        {
            // Arrange
            var boundary = new SquareBoundary(5);
            var toy = Toy.CreateToyRobot(boundary, new Position(0, 0), Directions.North);

            // Act
            toy.Rotate(Rotations.Right);

            // Assert
            Assert.Equal(Directions.East, toy.GetDirection());
        }

        [Fact]
        public void ToyRobot_CanRotateLeft()
        {
            // Arrange
            var boundary = new SquareBoundary(5);
            var toy = Toy.CreateToyRobot(boundary, new Position(0, 0), Directions.North);

            // Act
            toy.Rotate(Rotations.Left);

            // Assert
            Assert.Equal(Directions.West, toy.GetDirection());
        }

        [Fact]
        public void ToyRobot_CanRotateAndMove()
        {
            // Arrange
            var boundary = new SquareBoundary(5);
            var toy = Toy.CreateToyRobot(boundary, new Position(1, 0), Directions.North);

            // Act
            toy.Rotate(Rotations.Left);
            toy.Move();

            // Assert
            var position = toy.GetPosition();
            Assert.Equal(0, position.X);
            Assert.Equal(0, position.Y);
        }

        [Fact]
        public void ToyRobot_CanChangePosition()
        {
            // Arrange
            var boundary = new SquareBoundary(5);
            var toy = Toy.CreateToyRobot(boundary, new Position(0, 0), Directions.North);

            // Act
            toy.SetPosition(new Position(1, 2));

            // Assert
            var position = toy.GetPosition();
            Assert.Equal(1, position.X);
            Assert.Equal(2, position.Y);
        }

        [Fact]
        public void ToyRobot_CanMoveWithinBounds()
        {
            // Arrange
            var boundary = new SquareBoundary(5);
            var toy = Toy.CreateToyRobot(boundary, new Position(4, 4), Directions.North);

            // Act
            toy.Move();

            // Assert
            var position = toy.GetPosition();
            Assert.Equal(4, position.X);
            Assert.Equal(4, position.Y);
        }
    }
}
