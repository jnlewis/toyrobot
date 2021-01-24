using RobotApp.Domain.ValueObjects;

namespace RobotApp.Application.Boundaries
{
    public class SquareBoundary : IBoundary
    {
        private readonly int boundaryX;
        private readonly int boundaryY;

        public SquareBoundary(int length)
        {
            boundaryX = length;
            boundaryY = length;
        }

        public bool IsWithinBoundary(Position position)
        {
            // Check if position is within boundary
            if (position.X < 0 || position.X >= boundaryX)
            {
                // Outside of X boundary
                return false;
            }
            if (position.Y < 0 || position.Y >= boundaryY)
            {
                // Outside of Y boundary
                return false;
            }

            return true;
        }
    }
}
