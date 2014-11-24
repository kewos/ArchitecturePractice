using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DragonQuestWFA.Common.Entities;
using System.Xml.Serialization;
using System.IO;
using System.Xml;
using System.Configuration;

namespace DragonQuestWFA.Common
{
    public class SerializableObjectBuilder<T>
        where T : BaseObject
    {
        List<T> objs = new List<T>();
        private string _xmlFilePath;
        private string _xmlNodePath;

        public SerializableObjectBuilder<T> SetXmlFilePath(string xmlFilePath)
        {
            _xmlFilePath = xmlFilePath;
            return this;
        }

        public SerializableObjectBuilder<T> SetXmlNodePath(string xmlNodePath)
        {
            _xmlNodePath = xmlNodePath;
            return this;
        }

        private XmlNodeList GetXmlNodes()
        {
            using (XmlReader reader = XmlReader.Create(ConfigurationManager.AppSettings[_xmlFilePath]))
            {
                XmlDocument _xmlDoc = new XmlDocument();
                _xmlDoc.Load(reader);
                return _xmlDoc.SelectNodes(_xmlNodePath);
            }
        }

        public List<T> GetObject()
        {
            foreach (XmlNode fatherNode in GetXmlNodes())
            {
                T obj = (T)Activator.CreateInstance(typeof(T)); ;
                obj.Deserialize(fatherNode);
                objs.Add(obj);
            }

            return objs;
        }
    }
}
