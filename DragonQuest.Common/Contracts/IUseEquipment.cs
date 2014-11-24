using System;
using System.Collections.Generic;

namespace DragonQuestWFA.Common
{
    /**
     * 可裝備物品的
     **/
    public interface IUseEquipment
    {
        //所裝備的武器
        Weapon Weapon { get; set; }
    }
}
