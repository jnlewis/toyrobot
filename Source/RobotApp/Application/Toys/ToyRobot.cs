using RobotApp.Application.Boundaries;
using RobotApp.Domain.ValueObjects;

namespace RobotApp.Application.Toys
{
    public class ToyRobot : Toy, IToy
    {
        public ToyRobot(IBoundary boundary) : base(boundary)
        {
        }

        public override void Move()
        {
            if (base.MoveStrategy != null)
            {
                Position newPosition = base.MoveStrategy.Move(base.CurrentDirection, base.CurrentPosition);
                if (base.IsWithinBoundary(newPosition))
                {
                    base.SetPosition(newPosition);
                }
            }
        }

        public override void Rotate(Rotations rotation)
        {
            if (base.RotateStrategy != null)
            {
                Directions newDirection = base.RotateStrategy.Rotate(base.CurrentDirection, rotation);
                base.CurrentDirection = newDirection;
            }
        }
    }
}
