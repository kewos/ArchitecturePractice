using System;
using System.Collections.Generic;

namespace DragonQuestWFA.Common
{
    /**
     * 會掉落物品的
     **/
    public interface IDropItemList
    {
        //掉落物品列表
        Dictionary<string, int> DropItemList { get; set; }
    }
}
