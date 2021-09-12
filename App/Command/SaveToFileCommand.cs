using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace App.Command
{
    class SaveToFileCommand : ICommand
    {
        public string GetMenuRow()
        {
            return "Save in file";
        }
        public bool Run()
        {
            
            WriteLine("Saved");
            return false;
        }
    }
}
