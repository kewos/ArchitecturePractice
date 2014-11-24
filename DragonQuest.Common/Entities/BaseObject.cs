using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DragonQuestWFA.Common.Entities
{
    public abstract class BaseObject : ISerializable
    {
        protected Hashtable properties = new Hashtable();

        protected void SetValue(string propertyName, object value)
        {
            if (!properties.ContainsKey(propertyName)) return;
            properties[propertyName] = value;
        }

        protected object GetValue(string propertyName)
        {
            if (properties.ContainsKey(propertyName))
            {
                return properties[propertyName];
            }

            return null;
        }
        protected void OnAddProperty(string propertyName, object value)
        {
            properties[propertyName] = value; 
        }

        protected abstract void InitProperties();

        #region ISerializable Members
        public virtual void Serialize(System.Xml.XmlNode data)
        {
            throw new Exception("");
        }

        public virtual void Deserialize(System.Xml.XmlNode data)
        {
            foreach (System.Xml.XmlNode _childNode in data.ChildNodes)
            {
                SetValue(_childNode.Name, _childNode.InnerText);
            }
        }
        #endregion
    }
}
