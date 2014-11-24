using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Runtime.Serialization;

namespace DragonQuestWFA.Common.Entities
{
    public class CharactorProperty : BaseObject, ICharactorProperty 
    {
        public CharactorProperty()
        {
            InitProperties();
        }

        #region 角色屬性
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

        public int MaxHp
        {
            get
            {
                return Convert.ToInt32(GetValue("MaxHp"));
            }
            set
            {
                SetValue("MaxHp", value);
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

        public int Atk
        {
            get
            {
                return (Weapon != null) ? 
                    Convert.ToInt32(GetValue("Atk")) + Weapon.Damage : 
                    Convert.ToInt32(GetValue("Atk"));
            }
            set
            {
                SetValue("Atk", value);
            }
        }

        public Weapon Weapon { get; set; }

        public int UpgradeAtk
        {
            get
            {
                return Convert.ToInt32(GetValue("UpgradeAtk"));
            }
            set
            {
                SetValue("UpgradeAtk", value);
            }
        }

        public int UpgradeDef
        {
            get
            {
                return Convert.ToInt32(GetValue("UpgradeDef"));
            }
            set
            {
                SetValue("UpgradeDef", value);
            }
        }

        public int UpgradeSpeed
        {
            get
            {
                return Convert.ToInt32(GetValue("UpgradeSpeed"));
            }
            set
            {
                SetValue("UpgradeSpeed", value);
            }
        }

        public int UpgradeMaxHp
        {
            get
            {
                return Convert.ToInt32(GetValue("UpgradeMaxHp"));
            }
            set
            {
                SetValue("UpgradeMaxHp", value);
            }
        }

        public int UpgradeMaxMp
        {
            get
            {
                return Convert.ToInt32(GetValue("UpgradeMaxMp"));
            }
            set
            {
                SetValue("UpgradeMaxMp", value);
            }
        }
        #endregion

        protected override void InitProperties()
        {
            OnAddProperty("Name", string.Empty);
            OnAddProperty("MaxHp", 0);
            OnAddProperty("Hp", 0);
            OnAddProperty("Speed", 0);
            OnAddProperty("MaxMp", 0);
            OnAddProperty("Mp", 0);
            OnAddProperty("Def", 0);
            OnAddProperty("Atk", 0);
            OnAddProperty("Lv", 0);
            OnAddProperty("Exp", 0);
            OnAddProperty("UpgradeAtk", 0);
            OnAddProperty("UpgradeDef", 0);
            OnAddProperty("UpgradeSpeed", 0);
            OnAddProperty("UpgradeMaxHp", 0);
            OnAddProperty("UpgradeMaxMp", 0);
        }
    }
}
