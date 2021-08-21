using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VampireBoardGameTest.Vampire.GameManagers
{

    public enum GameMode
    {
        Four,Five,Six
    }
    interface IGameMaster
    {

        void SetRoles();

    }
}
