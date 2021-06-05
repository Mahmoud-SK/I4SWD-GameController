using System;
using System.Collections.Generic;
using System.Text;

namespace I4SWD_GameController
{
	public class JumpCommand :ICommand
    {
        private GameCharacter gameCharacter;

        public JumpCommand(GameCharacter gameCharacter)
        {
           this.gameCharacter = gameCharacter;
        }
        public void Execute()
        {
            gameCharacter.Jump();
        }
    }
}
