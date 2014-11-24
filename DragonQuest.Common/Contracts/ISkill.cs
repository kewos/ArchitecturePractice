using System;
using System.Collections.Generic;

namespace DragonQuestWFA.Common
{
    public interface ISkill : IDescription
    {
        //所需魔力值
        int Mana { get; set; }
        //狀態列表
        List<IBuff> Buff { get; set; }
        //傷害百分比
        int DamagePercentage { get; set; }
        //傷害
        int Damage { get; set; }
        //攻擊數量
        int Range { get; set; }
        //施法
        Dictionary<string, object> Cast();
    }
}
