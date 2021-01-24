using Application;
using RobotApp.Application.Boundaries;
using RobotApp.Application.Toys;
using RobotApp.Domain.ValueObjects;
using System;

namespace RobotApp.Commands
{
    public class PlaceCommand : ICommand
    {
        private readonly int positionX;
        private readonly int positionY;
        private readonly Directions direction;

        public PlaceCommand(string[] args)
        {
            // Validate Input
            if (args.Length > 0)
            {
                try
                {
                    var parts = args[0].Split(',');
                    this.positionX = Convert.ToInt32(parts[0]);
                    this.positionY = Convert.ToInt32(parts[1]);
                    this.direction = DirectionFromString(parts[2]);
                }
                catch
                {
                    throw new ArgumentException();
                }
            }
            else
            {
                throw new ArgumentException();
            }
        }

        private Directions DirectionFromString(string direction)
        {
            switch(direction)
            {
                case "NORTH":
                    return Directions.North;
                case "EAST":
                    return Directions.East;
                case "SOUTH":
                    return Directions.South;
                case "WEST":
                    return Directions.West;
                default:
                    throw new ArgumentException();
            }
        }

        public void Execute()
        {
            // Create a new square boundary with size 5x5
            var boundary = new SquareBoundary(5);

            // Create a new toy robot
            var robot = Toy.CreateToyRobot(boundary, new Position(this.positionX, this.positionY), this.direction);

            // Set the new toy on the platform
            Platform.Instance.SetCurrentToy(robot);
        }
    }
}
