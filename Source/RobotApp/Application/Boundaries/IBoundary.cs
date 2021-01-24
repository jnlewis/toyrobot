using RobotApp.Domain.ValueObjects;

namespace RobotApp.Application.Boundaries
{
    public interface IBoundary
    {
        bool IsWithinBoundary(Position position);
    }
}
