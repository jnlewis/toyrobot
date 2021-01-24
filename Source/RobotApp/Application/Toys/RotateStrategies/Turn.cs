using System.Collections.Generic;
using System.Linq;

namespace RobotApp.Application.Toys.RotateStrategies
{
    public class Turn : RotateStrategy
    {
        public override Directions Rotate(Directions currentDirection, Rotations rotation)
        {
            Dictionary<Directions, int> rotationMap = new Dictionary<Directions, int>()
            {
                { Directions.North, 0 },
                { Directions.East, 1 },
                { Directions.South, 2 },
                { Directions.West, 3 }
            };

            int rotationPoint =
                rotation == Rotations.Left ? -1 :
                rotation == Rotations.Right ? 1 :
                0;

            int currentPoint = rotationMap[currentDirection];

            int newPoint = currentPoint + rotationPoint;
            if (newPoint >= 0)
            {
                newPoint = newPoint % 4;
            }
            else
            {
                var offset = (System.Math.Abs(newPoint) % 4);
                newPoint = 4 - (offset == 0 ? 4 : offset);
            }

            return rotationMap.FirstOrDefault(x => x.Value == newPoint).Key;
        }
    }
}
