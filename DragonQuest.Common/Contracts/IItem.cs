using System;
using System.Collections.Generic;

namespace DragonQuestWFA.Common
{
    /**
     * 物品
     **/
    public interface IItem : IDescription
    {
        //種類
        string Kind { get; set; }
        //價錢
        int Price { get; set; }
    }
}
