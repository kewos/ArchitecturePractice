using DragonQuestWFA.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonQuestWFA.Engine
{
    public interface IBattleState
    {
        void Execute(BattleEventArgs args);
        void Initail(BattleEvents events);
    }
}
