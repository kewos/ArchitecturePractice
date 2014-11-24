using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DragonQuestWFA.Common.Entities
{
    public interface ISerializable
    {
        void Serialize(System.Xml.XmlNode data);
        void Deserialize(System.Xml.XmlNode data);
    }
}
