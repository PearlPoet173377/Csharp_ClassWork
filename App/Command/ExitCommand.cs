using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace App.Command
{
    class ExitCommand : ICommand
    {
        public string GetMenuRow()
        {
            return "Exit";
        }
        public bool Run()
        {
            return true;
        }
    }
}
