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
    public class SerializableMaps<TType> : AbstractSerializableObjects<TType>
        where TType : IMapProperty
    {
        protected override void SetObjectProperty(XmlNodeList _fatherNodes)
        {
            foreach (XmlNode _fatherNode in _fatherNodes)
            {
                TType obj = (TType)Activator.CreateInstance(typeof(TType)); ;
                Objects.Add(obj);

                foreach (XmlNode _childNodes in _fatherNode.ChildNodes)
                {
                    if (_childNodes.Name == "Name")
                    {
                        obj.Name = _childNodes.InnerText;
                    }
                    if (_childNodes.Name == "Description")
                    {
                        obj.Description = _childNodes.InnerText;
                    }
                    if (_childNodes.Name == "MaxMonsterNum")
                    {
                        obj.MaxMonsterNum = Convert.ToInt32(_childNodes.InnerText);
                    }
                    if (_childNodes.Name == "MinMonsterNum")
                    {
                        obj.MinMonsterNum = Convert.ToInt32(_childNodes.InnerText);
                    }
                    if (_childNodes.Name == "MonsterProbability")
                    {
                        obj.MonsterList.Add(_childNodes.Attributes["Name"].Value, Convert.ToInt32(_childNodes.Attributes["Value"].Value));
                    }
                }
            }
        }

        protected override XmlNodeList GetFatherNodes()
        {
            string _xPath = "/ArrayOfMapProperty/MapProperty";
            XmlNodeList _fatherNodes = _xmlDoc.SelectNodes(_xPath);

            return _fatherNodes;
        }
    }
     * */
}
