using System;
using System.Collections.Generic;
using System.Text;

namespace App.Command
{
    interface ICommand
    {
        string GetMenuRow();
        bool Run();
    }
}
