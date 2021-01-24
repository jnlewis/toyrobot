using RobotApp.Domain.ValueObjects;
using System;

namespace RobotApp.Application.Toys.MoveStrategies
{
    public abstract class MoveStrategy
    {
        public abstract Position Move(Directions currentDirection, Position currentPosition);
    }
}
