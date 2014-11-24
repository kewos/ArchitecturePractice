using System;
using System.Collections.Generic;

namespace DragonQuestWFA.Common
{
    public interface IMapProperty : IDescription
    {
        #region Map屬性
        //可能到的遭遇怪物及機率
        Dictionary<string, int> MonsterList { get; set; }
        //最多遭遇到的怪物數量
        int MaxMonsterNum { get; set; }
        //最少遭遇到的怪物數量
        int MinMonsterNum { get; set; }
        #endregion
    }
}
