using System;
using System.Collections.Generic;
using System.Text;

namespace I4SWD_GameController
{
	class ControllerLoader
	{
		static void Main(string[] args)
		{
			//opretelse af Receivers
			GameCharacter GC = new GameCharacter();
			Menu menu = new Menu();
			Building building = new Building();

			//oprettelse af commands
			AttackCommand atk = new AttackCommand(GC);
			JumpCommand jmp = new JumpCommand(GC);
			OpenMenuCommand openMenu = new OpenMenuCommand(menu);
			UpgradeCommand upgrade = new UpgradeCommand(building);

			Controller control = new Controller();
			//her bindes de forskellige commands til hver deres knap.
			control.setCommand(jmp, 0);
			control.setCommand(atk, 1);
			control.setCommand(openMenu, 2);
			control.setCommand(upgrade, 3);

			//Test hvor der trykkes på hver knap en gang.
			control.buttonPushed(0);
			control.buttonPushed(1);
			control.buttonPushed(2);
			control.buttonPushed(3);


		}
	}
}
