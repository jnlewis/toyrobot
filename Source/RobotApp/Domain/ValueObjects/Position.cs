using System;
using System.Collections.Generic;
using System.Text;

namespace RobotApp.Domain.ValueObjects
{
    public struct Position
    {
        public Position(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public int X { get; set; }
        public int Y { get; set; }

        public Position Add(Position position)
        {
            return new Position(this.X + position.X, this.Y + position.Y);
        }
    }
}
