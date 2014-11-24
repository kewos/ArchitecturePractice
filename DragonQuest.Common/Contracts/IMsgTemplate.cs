using System;
using System.Collections.Generic;

namespace DragonQuestWFA.Common
{
    public interface IMsgTemplate
    {
        //處理訊息
        string ProduceMsg(List<object> args);
        //取得訊息
        string GetMsg(List<object> data);
    }
}
