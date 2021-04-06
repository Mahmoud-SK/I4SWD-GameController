using System;
using System.Collections.Generic;
using System.Text;

namespace I4SWD_GameController
{
    class AttackCommand : ICommand
    {
        GameCharacter Character;

        public AttackCommand(GameCharacter Character)
        {
            this.Character = Character;
        }

        public void Execute()
        {
            Character.Attack();
        }
    }
}
