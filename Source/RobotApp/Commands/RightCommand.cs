using Application;
using RobotApp.Application.Toys;

namespace RobotApp.Commands
{
    public class RightCommand : ICommand
    {
        public RightCommand(string[] args)
        {

        }

        public void Execute()
        {
            Platform.Instance
                .GetCurrentToy()?
                .Rotate(Rotations.Right);
        }
    }
}
