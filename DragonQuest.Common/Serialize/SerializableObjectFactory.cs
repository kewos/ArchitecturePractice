using DragonQuestWFA.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonQuestWFA.Common
{
    public class SerializableObjectFactory
    {
        public static List<T> GetInstance<T>()
            where T : BaseObject
        {
            string _xmlFilePath = typeof(T).Name + "XmlPath";
            string _xmlNodePath = string.Format("/ArrayOf{0}/{1}", typeof(T).Name, typeof(T).Name);
            return new SerializableObjectBuilder<T>().SetXmlFilePath(_xmlFilePath).SetXmlNodePath(_xmlNodePath).GetObject();
        }

    }
}

