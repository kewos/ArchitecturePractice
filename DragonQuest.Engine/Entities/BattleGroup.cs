using DragonQuestWFA.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonQuestWFA.Engine
{
    public class BattleGroup : IBattleGroup
    {
        public List<ICharactorProperty> Charactor { get; set; }
        public List<ICharactorProperty> DieCharactor { get; set; }
        public List<IMonsterProperty> Monster { get; set; }
        public List<IMonsterProperty> DieMonster { get; set; }
    }
}
