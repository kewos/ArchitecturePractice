using System;
using System.Collections.Generic;

namespace DragonQuestWFA.Common
{
    public interface IMsgCollector
    {
        //收集字串
        void SaveMsg(string msg);
        //填充字串並取得
        string InflateMsgAndGet(IMsgTemplate template, List<object> data);
        //填充字串並取得
        string InflateMsgAndGet<T>(List<object> args);
        //收集字串
        void SaveMsg(IMsgTemplate template, List<object> data);
        //收集字串
        void SaveMsg<T>(List<object> data);
        //清空並取得字串
        string GetMsgAndClear();
        //取得字串
        string GetMsg();
    }
}
