using App.Command;
using System.Collections.Generic;
using static System.Console;

namespace App
{
    class MenuRunner
    {
        private List<ICommand> commands;
        public MenuRunner(List<ICommand> commands)
        {
            this.commands = commands;
        }
        public void MenuRun()
        {
            bool isExit = false;
            do
            {
                WriteLine("Меню");
                WriteLine("Введите номер нужного действия");
                //Добавил проверку на корректность введенного пункта меню
                int num;
                int MenuRows;
                do
                {
                    Clear();
                    num = 1;
                    foreach (ICommand command in commands)
                    {
                        WriteLine(num + ". " + command.GetMenuRow());
                        num++;
                    }
                    MenuRows = num;

                    string userInput = ReadLine();
                    num = int.Parse(userInput);
                    
                }
                while (num >= MenuRows||num<1);

                isExit = commands[num - 1].Run();
                WriteLine("Press any key to continue......");
                ReadLine();
                Clear();
            } while (!isExit);
        }
    }
}