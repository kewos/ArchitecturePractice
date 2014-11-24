using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace DragonQuestWFA.Common
{
    /*
    public abstract class AbstractSerializableObjects<TType> : IXmlSerializable
    {
        public List<TType> Objects { get; set; }
        protected XmlDocument _xmlDoc;

        public AbstractSerializableObjects()
        {
            Objects = new List<TType>();
        }

        #region IXmlSerializable 方法
        public System.Xml.Schema.XmlSchema GetSchema()
        {
            throw new NotImplementedException();
        }

        public void ReadXml(XmlReader reader)
        {
            SetXmlDocument(reader);

            XmlNodeList _fatherNodes = GetFatherNodes();

            SetObjectProperty(_fatherNodes);
        }

        public void WriteXml(XmlWriter writer)
        {
            throw new NotImplementedException();
        }
        #endregion

        public virtual void SetXmlDocument(XmlReader reader)
        {
            this._xmlDoc = new XmlDocument();
            this._xmlDoc.Load(reader);
        }
        //設定屬性
        protected abstract void SetObjectProperty(XmlNodeList _fatherNodes);

        protected abstract XmlNodeList GetFatherNodes();

        public List<TType> GetObjects()
        {
            return Objects;
        }
    }
    */
}
