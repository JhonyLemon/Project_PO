using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO_Project
{
    class Invoker
    {
        private ICommand command;

        // Initialize commands.
        public void SetCommand(ICommand command)
        {
            this.command = command;
        }
        public void PerformCommand()
        {
            Console.WriteLine("Invoker: Does anybody want something done before I begin?");
            if (this.command is ICommand)
            {
                this.command.Execute();
            }

        }
    }
}
