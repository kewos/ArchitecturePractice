using System;
using System.Collections.Generic;

namespace DragonQuestWFA.Common
{
    /**
     * 使用技能的
     **/
    public interface IUseSkill
    {
        //可使用的技能
        List<ISkill> _skill { get; set; }
        //使用何種技能
        List<object> UseWhichSkill(List<IUnitProperty> enemies);
    }
}
