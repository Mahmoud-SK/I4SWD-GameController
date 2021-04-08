using System;
using System.Collections.Generic;
using System.Text;

namespace I4SWD_GameController
{
    public class AttackCommand : ICommand
    {
        private GameCharacter gameCharacter;

        public AttackCommand(GameCharacter Character)
        {
            this.gameCharacter = Character;
        }

        public void Execute()
        {
            gameCharacter.Attack();
        }
    }
}
