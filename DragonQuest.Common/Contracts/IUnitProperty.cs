using System;
using System.Collections.Generic;

namespace DragonQuestWFA.Common
{
    /**
     * 擁有屬性值的
     **/
    public interface IUnitProperty : IDescription
    {
        //攻擊值
        int Atk { get; set; }
        //防禦值
        int Def { get; set; }
        //行走速度
        int Speed { get; set; }
        //最大生命值
        int MaxHp { get; set; }
        //當前生命值
        int Hp { get; set; }
        //最大法力值
        int MaxMp { get; set; }
        //當前法力值
        int Mp { get; set; }
        //等級
        int Lv { get; set; }
        //經驗
        int Exp { get; set; }
    }
}
