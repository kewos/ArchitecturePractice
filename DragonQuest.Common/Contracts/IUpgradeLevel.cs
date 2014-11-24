using System;
using System.Collections.Generic;

namespace DragonQuestWFA.Common
{
    /**
     *可升級的 
     **/
    public interface IUpgradeLevel
    {
        //攻擊升級值
        int UpgradeAtk { get; set; }
        //防禦升級值
        int UpgradeDef { get; set; }
        //敏捷升級值
        int UpgradeSpeed { get; set; }
        //生命升級值
        int UpgradeMaxHp { get; set; }
        //魔力升級值
        int UpgradeMaxMp { get; set; }
    }
}
