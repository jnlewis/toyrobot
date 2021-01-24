using System;
using System.Collections.Generic;
using System.Text;

namespace RobotApp.Commands.Factories
{
    public class MoveCommandFactory : CommandFactory
    {
        public override ICommand Create(string[] args) => new MoveCommand(args);
    }
}
