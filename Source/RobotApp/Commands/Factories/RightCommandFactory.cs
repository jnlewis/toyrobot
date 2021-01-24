using System;
using System.Collections.Generic;
using System.Text;

namespace RobotApp.Commands.Factories
{
    public class RightCommandFactory : CommandFactory
    {
        public override ICommand Create(string[] args) => new RightCommand(args);
    }
}
