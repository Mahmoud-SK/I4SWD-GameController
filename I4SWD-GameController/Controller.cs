using System;
using System.Collections.Generic;
using System.Text;

namespace I4SWD_GameController
{
    public class Controller
    {
        private ICommand[] commands;
        private int numberOfButtons = 4;

        public Controller()
        {
            commands = new ICommand[numberOfButtons];

            for (int i = 0; i < numberOfButtons; i++)
            {
                commands[i] = new NoCommand();
            }
        }

        public void setCommand(ICommand command, int index)
        {
            if (index >= 0 && index < numberOfButtons)
            {
                commands[index] = command;
            }
        }

        public void buttonPushed(int index)
        {
            if (index >= 0 && index < numberOfButtons)
            {
                commands[index].Execute();
            }

        }
    }
}
