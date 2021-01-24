using Application;
using System;

namespace RobotApp.Commands
{
    public class MoveCommand : ICommand
    {
        public MoveCommand(string[] args)
        {

        }

        public void Execute()
        {
            Platform.Instance
                .GetCurrentToy()?
                .Move();
        }
    }
}
