using System;
using System.Collections.Generic;

namespace DragonQuestWFA.Common
{
    /**
     * 可以描述的
     **/
    public interface IDescription
    {
        //名稱
        string Name { get; set; }
        //描述
        string Description { get; set; }
    }
}
