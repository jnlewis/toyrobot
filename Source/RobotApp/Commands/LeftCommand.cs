using Application;
using RobotApp.Application.Toys;

namespace RobotApp.Commands
{
    public class LeftCommand : ICommand
    {
        public LeftCommand(string[] args)
        {

        }

        public void Execute()
        {
            Platform.Instance
                .GetCurrentToy()?
                .Rotate(Rotations.Left);
        }
    }
}
