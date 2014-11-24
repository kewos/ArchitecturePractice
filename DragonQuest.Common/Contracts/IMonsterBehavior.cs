using System;
using System.Collections.Generic;

namespace DragonQuestWFA.Common
{
    public interface IMonsterBehavior
    {
        //掉落物品
        List<string> DropItems();
        //設定生命法力
        void SetHpMpMax();
    }
}
