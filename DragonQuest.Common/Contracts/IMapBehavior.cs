using System;
using System.Collections.Generic;

namespace DragonQuestWFA.Common
{
    public interface IMapBehavior
    {
        #region Map行為
        //產出對戰怪物名稱
        List<string> ProduceMonsterList();
        //此地圖事件遭遇機率
        void TargetEventProbability();
        #endregion
    }
}
