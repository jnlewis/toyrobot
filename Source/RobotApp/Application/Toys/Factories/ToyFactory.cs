using RobotApp.Application.Boundaries;
using RobotApp.Domain.ValueObjects;
using System;

namespace RobotApp.Application.Toys.Factories
{
    public abstract class ToyFactory
    {
        public abstract IToy Create(IBoundary boundary, Position position, Directions direction);
    }
}
