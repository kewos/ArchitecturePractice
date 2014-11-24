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
    public class SerializableCharactors<TType> : AbstractSerializableObjects<TType>
         where TType : ICharactorProperty
    {
        protected override void SetObjectProperty(XmlNodeList _fatherNodes)
        {
            foreach (XmlNode _fatherNode in _fatherNodes)
            {
                TType obj = (TType)Activator.CreateInstance(typeof(TType)); ;
                Objects.Add(obj);

                Console.WriteLine(obj.GetType().GetProperty("Name").GetType());
                foreach (XmlNode _childNodes in _fatherNode.ChildNodes)
                {
                    if (_childNodes.Name == "Name") obj.Name = _childNodes.InnerText;
                    else if (_childNodes.Name == "Atk") obj.Atk = Convert.ToInt32(_childNodes.InnerText);
                    else if (_childNodes.Name == "Def") obj.Def = Convert.ToInt32(_childNodes.InnerText);
                    else if (_childNodes.Name == "Speed") obj.Speed = Convert.ToInt32(_childNodes.InnerText);
                    else if (_childNodes.Name == "Lv") obj.Lv = Convert.ToInt32(_childNodes.InnerText);
                    else if (_childNodes.Name == "Exp") obj.Exp = Convert.ToInt32(_childNodes.InnerText);
                    else if (_childNodes.Name == "MaxHp") obj.MaxHp = Convert.ToInt32(_childNodes.InnerText);
                    else if (_childNodes.Name == "Hp") obj.Hp = Convert.ToInt32(_childNodes.InnerText);
                    else if (_childNodes.Name == "MaxMp") obj.MaxMp = Convert.ToInt32(_childNodes.InnerText);
                    else if (_childNodes.Name == "Mp") obj.Mp = Convert.ToInt32(_childNodes.InnerText);
                    else if (_childNodes.Name == "UpgradeAtk") obj.UpgradeAtk = Convert.ToInt32(_childNodes.InnerText);
                    else if (_childNodes.Name == "UpgradeDef") obj.UpgradeDef = Convert.ToInt32(_childNodes.InnerText);
                    else if (_childNodes.Name == "UpgradeSpeed") obj.UpgradeSpeed = Convert.ToInt32(_childNodes.InnerText);
                    else if (_childNodes.Name == "UpgradeMaxHp") obj.UpgradeMaxHp = Convert.ToInt32(_childNodes.InnerText);
                    else if (_childNodes.Name == "UpgradeMaxMp") obj.UpgradeMaxMp = Convert.ToInt32(_childNodes.InnerText);
                }
            }
        }

        protected override XmlNodeList GetFatherNodes()
        {
            string _xPath = "/ArrayOfCharactorProperty/CharactorProperty";
            XmlNodeList _fatherNodes = _xmlDoc.SelectNodes(_xPath);

            return _fatherNodes;
        }
    }
     * */
}
