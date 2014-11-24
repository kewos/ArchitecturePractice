using DragonQuestWFA.Common;
using System;
using System.Collections.Generic;

namespace DragonQuestWFA.Engine
{
    public interface IBattleGroup
    {
        //角色清單
        List<ICharactorProperty> Charactor { get; set; }
        //死亡角色清單
        List<ICharactorProperty> DieCharactor { get; set; }
        //怪物清單
        List<IMonsterProperty> Monster { get; set; }
        //死亡怪物清單
        List<IMonsterProperty> DieMonster { get; set; }
    }
}
