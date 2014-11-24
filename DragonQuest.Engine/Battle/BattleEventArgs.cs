using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonQuestWFA.Engine
{
    public class BattleEventArgs : EventArgs
    {
        public IBattleGroup BattleGroup { get; set; }
        public List<object> Data { get; set; }

        public BattleEventArgs(IBattleGroup battleGroup)
        {
            BattleGroup = battleGroup;
        }
    }
}
