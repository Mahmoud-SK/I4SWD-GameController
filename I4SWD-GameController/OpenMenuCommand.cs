using System;
using System.Collections.Generic;
using System.Text;

namespace I4SWD_GameController
{
	public class OpenMenuCommand : ICommand
	{
        private Menu _gameMenu;

        public OpenMenuCommand(Menu gameMenu)
        {
            this._gameMenu = gameMenu;
        }
        public void Execute()
        {
            _gameMenu.OpenMenu();
        }
    }
}
