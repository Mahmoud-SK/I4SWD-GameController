using System;
using System.Collections.Generic;
using System.Text;

namespace I4SWD_GameController
{
    //NoCommand er et Null object. Det vil sige at den gør ingenting i dens Execute. Den er lavet for at Null ikke skal håndteres i Controller klassen.
    public class NoCommand : ICommand
    {
        public void Execute()
        {
        }
    }
}
