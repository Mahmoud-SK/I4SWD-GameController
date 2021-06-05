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
            //commands er et array hvor hver plads svare til en knap.
            commands = new ICommand[numberOfButtons];
            
            //her fyldes arrayet med Nocommands. Det gøres for at der ikke står Null i arrayet og Execute i buttonPushed dermed altid kan kaldes.
            for (int i = 0; i < numberOfButtons; i++)
            {
                commands[i] = new NoCommand();
            }
        }

        //setCommand bruges til at binde en command sammen med en knap valgt via index.
        public void setCommand(ICommand command, int index)
        {
            //her tjekkes det at indexet er gyldigt.
            if (index >= 0 && index < numberOfButtons)
            {
                commands[index] = command;
            }
        }

        //buttonPushed bruges til at simulere at der trykkes på en knap.
        public void buttonPushed(int index)
        {
            //her tjekkes det at indexet er gyldigt.
            if (index >= 0 && index < numberOfButtons)
            {
                commands[index].Execute();
            }

        }
    }
}
