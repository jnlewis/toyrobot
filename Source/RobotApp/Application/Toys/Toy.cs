using RobotApp.Application.Boundaries;
using RobotApp.Application.Toys.Factories;
using RobotApp.Application.Toys.MoveStrategies;
using RobotApp.Application.Toys.RotateStrategies;
using RobotApp.Domain.Exceptions;
using RobotApp.Domain.ValueObjects;

namespace RobotApp.Application.Toys
{
    public abstract class Toy
    {
        private readonly IBoundary boundary;

        protected Toy(IBoundary boundary)
        {
            this.boundary = boundary;
        }

        #region Factory

        public static IToy CreateToyRobot(IBoundary boundary, Position position, Directions direction)
        {
            var factory = new ToyRobotFactory();
            return factory.Create(boundary, position, direction);
        }

        #endregion

        #region Protected

        protected Position CurrentPosition { get; set; }
        protected Directions CurrentDirection { get; set; }
        protected MoveStrategy MoveStrategy { get; set; }
        protected RotateStrategy RotateStrategy { get; set; }

        protected bool IsWithinBoundary(Position position)
        {
            return this.boundary.IsWithinBoundary(position);
        }

        #endregion

        #region Public

        public virtual void SetPosition(Position position)
        {
            if (!this.IsWithinBoundary(position))
            {
                throw new PositionOutOfBoundsException();
            }

            this.CurrentPosition = position;
        }

        public virtual Position GetPosition()
        {
            return this.CurrentPosition;
        }

        public virtual void SetDirection(Directions direction)
        {
            this.CurrentDirection = direction;
        }

        public virtual Directions GetDirection()
        {
            return this.CurrentDirection;
        }

        public virtual void SetMoveStrategy(MoveStrategy moveStrategy)
        {
            this.MoveStrategy = moveStrategy;
        }

        public virtual void SetRotateStrategy(RotateStrategy rotateStrategy)
        {
            this.RotateStrategy = rotateStrategy;
        }

        #endregion

        #region Abstracts

        public abstract void Move();

        public abstract void Rotate(Rotations rotation);

        #endregion
    }
}
