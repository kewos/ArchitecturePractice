using DragonQuestWFA.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonQuestWFA.Engine
{
    public abstract class AbstractBattleState : IBattleState
    {
        public abstract void Execute(BattleEventArgs args);
        public abstract void Initail(BattleEvents events);
    }
}
