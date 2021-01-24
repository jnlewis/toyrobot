using RobotApp.Application.Boundaries;
using RobotApp.Application.Toys.MoveStrategies;
using RobotApp.Application.Toys.RotateStrategies;
using RobotApp.Domain.ValueObjects;
using System;

namespace RobotApp.Application.Toys.Factories
{
    public class ToyRobotFactory : ToyFactory
    {
        public override IToy Create(IBoundary boundary, Position position, Directions direction)
        {
            var toy = new ToyRobot(boundary);
            toy.SetDirection(direction);
            toy.SetPosition(position);
            toy.SetMoveStrategy(new Walk());
            toy.SetRotateStrategy(new Turn());

            return toy;
        }
    }
}
