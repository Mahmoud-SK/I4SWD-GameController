using System;
using System.Collections.Generic;
using System.Text;

namespace I4SWD_GameController
{
	public class UpgradeCommand : ICommand
    {
        private Building _building;

        public UpgradeCommand(Building building)
        {
            this._building = building;
        }
        public void Execute()
        {
            _building.Upgrade();
        }
    }
}
