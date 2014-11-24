using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonQuestWFA.Engine
{
    public class BattleEvents
    {
        public BattleStateDelegate<BattleEventArgs> BattleState { get; set; }
        public BattleStateDelegate<BattleEventArgs> CharactorDieState { get; set; }
        public BattleStateDelegate<BattleEventArgs> CharactorVictoryState { get; set; }
        public BattleStateDelegate<BattleEventArgs> CheckBattleState { get; set; }
        public BattleStateDelegate<BattleEventArgs> DropItemState { get; set; }
        public BattleStateDelegate<BattleEventArgs> MonsterDieState { get; set; }
        public BattleStateDelegate<BattleEventArgs> MonsterVictoryState { get; set; }
        public BattleStateDelegate<BattleEventArgs> RaiseExpState { get; set; }
    }
}
