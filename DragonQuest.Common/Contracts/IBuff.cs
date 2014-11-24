using System;
using System.Collections.Generic;

namespace DragonQuestWFA.Common
{
    /**
     * 狀態 有分有益狀態及負面狀態
     **/
    public interface IBuff : IDescription
    {
        //影響回合數
        int Time { get; set; }
        //影響效果
        int EffectPower { get; set; }
        //影響百分比
        int EffectPercentage { get; set; }
        //影響狀態
        List<object> Effect();
    }
}
