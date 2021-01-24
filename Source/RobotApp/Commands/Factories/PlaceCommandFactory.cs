using System;
using System.Collections.Generic;
using System.Text;

namespace RobotApp.Commands.Factories
{
    public class PlaceCommandFactory : CommandFactory
    {
        public override ICommand Create(string[] args) => new PlaceCommand(args);
    }
}
