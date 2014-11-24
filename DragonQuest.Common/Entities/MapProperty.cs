using System.Xml.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DragonQuestWFA.Common.Entities
{
    public class MapProperty : BaseObject, IMapProperty
    {
        public MapProperty()
        {
            InitProperties();
        }
        #region Map屬性
        public string Name
        {
            get
            {
                return (string)GetValue("Name");
            }
            set
            {
                SetValue("Name", value);
            }
        }

        public string Description
        {
            get
            {
                return (string)GetValue("Description");
            }
            set
            {
                SetValue("Description", value);
            }
        }

        public Dictionary<string, int> MonsterList
        {
            get
            {
                return (Dictionary<string, int>)GetValue("MonsterList");
            }
            set
            {
                SetValue("MonsterList", value);
            }
        }

        public int MaxMonsterNum
        {
            get
            {
                return Convert.ToInt32(GetValue("MaxMonsterNum"));
            }
            set
            {
                SetValue("MaxMonsterNum", value);
            }
        }

        public int MinMonsterNum
        {
            get
            {
                return Convert.ToInt32(GetValue("MinMonsterNum"));
            }
            set
            {
                SetValue("MinMonsterNum", value);
            }
        }
        #endregion

        protected override void InitProperties()
        {
            OnAddProperty("Name", string.Empty);
            OnAddProperty("Description", string.Empty);
            OnAddProperty("MonsterList", new Dictionary<string, int>());
            OnAddProperty("MaxMonsterNum", 0);
            OnAddProperty("MinMonsterNum", 0);
        }

        #region ISerialize
        public override void Serialize(System.Xml.XmlNode data)
        {
            throw new NotImplementedException();
        }

        public override void Deserialize(System.Xml.XmlNode data)
        {
            foreach (System.Xml.XmlNode _childNode in data.ChildNodes)
            {
                if (_childNode.Name == "MonsterList")
                {
                    MonsterList.Add(
                        _childNode.Attributes["Name"].Value, 
                        Convert.ToInt32(_childNode.Attributes["Value"].Value)
                        );

                    continue;
                }

                SetValue(_childNode.Name, _childNode.InnerText);
            }
        }
        #endregion 
    }
}
