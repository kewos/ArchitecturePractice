using System.Xml.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace DragonQuestWFA.Common.Entities
{
    public class MonsterProperty :BaseObject, IMonsterProperty
    {
        public MonsterProperty()
        {
            InitProperties();
        }

        #region 怪物屬性
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


        public Dictionary<string, int> DropItemList
        {
            get
            {
                return (Dictionary<string, int>)GetValue("DropItemList");
            }
            set
            {
                SetValue("DropItemList", value);
            }
        }



        public int MaxHp { get; set; }

        public int Hp
        {
            get
            {
                int _hp = Convert.ToInt32(GetValue("Hp"));
                if (_hp < 0)
                {
                    _hp = 0;
                    SetValue("Hp", _hp);
                }
                return _hp;
            }
            set
            {
                SetValue("Hp", value);
            }
        }

        public int Speed
        {
            get
            {
                return Convert.ToInt32(GetValue("Speed"));
            }
            set
            {
                SetValue("Speed", value);
            }
        }

        public int MaxMp
        {
            get
            {
                return Convert.ToInt32(GetValue("MaxMp"));
            }
            set
            {
                SetValue("MaxMp", value);
            }
        }

        public int Mp
        {
            get
            {
                return Convert.ToInt32(GetValue("Mp"));
            }
            set
            {
                SetValue("Mp", value);
            }
        }

        public int Def
        {
            get
            {
                return Convert.ToInt32(GetValue("Def"));
            }
            set
            {
                SetValue("Def", value);
            }
        }

        public int Atk
        {
            get
            {
                return Convert.ToInt32(GetValue("Atk"));
            }
            set
            {
                SetValue("Atk", value);
            }
        }

        public int Lv
        {
            get
            {
                return Convert.ToInt32(GetValue("Lv"));
            }
            set
            {
                SetValue("Lv", value);
            }
        }

        public int Exp 
        { 
            get
            {
                return Convert.ToInt32(GetValue("Exp"));
            }
            set
            {
                SetValue("Exp", value);
            }
        }
        #endregion

        public override void Serialize(System.Xml.XmlNode data)
        {
            throw new NotImplementedException();
        }

        public override void Deserialize(System.Xml.XmlNode data)
        {
            foreach (System.Xml.XmlNode _childNode in data.ChildNodes)
            {
                if (_childNode.Name == "DropItemList")
                {
                    DropItemList.Add(
                        _childNode.Attributes["Name"].Value,
                        Convert.ToInt32(_childNode.Attributes["Value"].Value)
                        );

                    continue;
                }

                SetValue(_childNode.Name, _childNode.InnerText);
            }
        }

        protected override void InitProperties()
        {
            OnAddProperty("Name", string.Empty);
            OnAddProperty("Description", string.Empty);
            OnAddProperty("DropItemList", new Dictionary<string, int>());
            OnAddProperty("MaxHp", 0);
            OnAddProperty("Hp", 0);
            OnAddProperty("Speed", 0);
            OnAddProperty("MaxMp", 0);
            OnAddProperty("Mp", 0);
            OnAddProperty("Def", 0);
            OnAddProperty("Atk", 0);
            OnAddProperty("Lv", 0);
            OnAddProperty("Exp", 0);
        }
    }
}
