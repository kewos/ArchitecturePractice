using DragonQuestWFA.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonQuestWFA.Engine
{
    public interface IBattleManager : IGameEvent
    {
        void Battle();
    }
}
