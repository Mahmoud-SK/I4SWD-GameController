using System;
using System.Collections.Generic;
using System.Text;

namespace I4SWD_GameController
{
	class ControllerLoader
	{
		static void Main(string[] args)
		{
			GameCharacter GC = new GameCharacter();
			AttackCommand atk = new AttackCommand(GC);
			JumpCommand jmp = new JumpCommand(GC);

			Controller control = new Controller();
			control.setCommand(jmp, 0);
			control.setCommand(atk, 1);

			control.buttonPushed(0);
			control.buttonPushed(1);


		}
	}
}
