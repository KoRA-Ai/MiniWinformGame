using GameLogic.ResourceManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic
{
    public class TurnSettlement
    {
        public TurnSettlement()
        {
        }

        public bool IsWinGame(CharacterManager characterManager, BattleSystem.BattleSystem battleSystem)
        {
            if (characterManager.GetAllCharactersCount() == 0)
            {
                return false;
            }

            //if (battleSystem.GetEnemyCount() == 0)
            //{
            //    return true ;
            //}
            return true;
        }

        public void ReassignCharacters(CharacterManager characterManager, BattleSystem.BattleSystem battleSystem, ref StringBuilder sbmsg)
        {
            if (characterManager.GetAllCharactersCount() > battleSystem.GetEnemyCount())
            {
                characterManager.RemoveCharacter_ForRoundEnd(ref sbmsg);
            }
        }
    }
}