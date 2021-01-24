using RobotApp.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace RobotApp.Application.Toys.MoveStrategies
{
    public class Walk : MoveStrategy
    {
        public override Position Move(Directions currentDirection, Position currentPosition)
        {
            Dictionary<Directions, Position> movementMap = new Dictionary<Directions, Position>()
            {
                { Directions.North, new Position(0, 1) },
                { Directions.South, new Position(0, -1) },
                { Directions.East, new Position(1, 0) },
                { Directions.West, new Position(-1, 0) }
            };

            // Calculate the new position after the move
            Position nextMovement = movementMap[currentDirection];
            Position newPosition = currentPosition.Add(nextMovement);

            return newPosition;
        }
    }
}
