using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO_Project
{
    class AddElementCommand: ICommand
    {
        private Receiver _receiver;

        // Context data, required for launching the receiver's methods.
        private string _a;

        private string _b;

        // Complex commands can accept one or several receiver objects along
        // with any context data via the constructor.
        public AddElementCommand(Receiver receiver, string a, string b)
        {
            this._receiver = receiver;
            this._a = a;
            this._b = b;
        }

        // Commands can delegate to any methods of a receiver.
        public void Execute()
        {
            this._receiver.AddElementForm();
        }
    }
}
