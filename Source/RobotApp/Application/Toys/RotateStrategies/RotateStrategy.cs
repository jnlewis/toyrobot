using System;
using System.Collections.Generic;
using System.Text;

namespace RobotApp.Application.Toys.RotateStrategies
{
    public abstract class RotateStrategy
    {
        public abstract Directions Rotate(Directions currentDirection, Rotations rotation);
    }
}
