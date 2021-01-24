using RobotApp.Domain.ValueObjects;

namespace RobotApp.Application.Toys
{
    public interface IToy
    {
        void Move();

        void Rotate(Rotations rotation);

        void SetPosition(Position position);

        Position GetPosition();

        void SetDirection(Directions direction);

        Directions GetDirection();
    }
}
