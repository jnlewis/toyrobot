using System;
using System.Collections.Generic;
using System.Text;

namespace RobotApp.Commands.Factories
{
    public abstract class CommandFactory
    {
        public abstract ICommand Create(string[] args);
    }
}
