using DragonQuestWFA.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DragonQuestWFA.Service
{
    public class MsgCollector : IMsgCollector
    {
        private StringBuilder _msg = new StringBuilder();

        public string InflateMsgAndGet(IMsgTemplate template, List<object> _data)
        {
            return template.GetMsg(_data);
        }

        public string InflateMsgAndGet<T>(List<object> _data)
        {
            return GetTemplate<T>().GetMsg(_data);
        }

        public void SaveMsg(string msg)
        {
            _msg.Append(msg);
        }

        public void SaveMsg(IMsgTemplate template, List<object> _data)
        {
            string _result = template.GetMsg(_data);
            _msg.Append(_result);
        }

        public void SaveMsg<T>(List<object> _data)
        {
            string _result = GetTemplate<T>().GetMsg(_data);
            _msg.Append(_result);
        }

        public string GetMsg()
        {
            return _msg.ToString();
        }

        public string GetMsgAndClear()
        {
            string tmp = _msg.ToString();
            _msg.Clear();

            return tmp;
        }

        private IMsgTemplate GetTemplate<T>()
        {
            return (IMsgTemplate)Activator.CreateInstance(typeof(T));
        }
    }
}
