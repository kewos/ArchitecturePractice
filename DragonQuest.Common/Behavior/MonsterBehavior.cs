using DragonQuestWFA.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Xml.Serialization;

namespace DragonQuestWFA.Common
{
    public class MonsterBehavior : IMonsterBehavior
    {
        IMonsterProperty _monsterProperty;

        public MonsterBehavior(IMonsterProperty monsterProperty)
        {
            this._monsterProperty = monsterProperty;
        }

        #region Monster行為
        public List<string> DropItems()
        {
            Random _random = new Random();
            return _monsterProperty.DropItemList.ToList()
                .Where(item => item.Value >= _random.Next(0, 100))
                .Select(item => item.Key)
                .ToList();
        }

        public void SetHpMpMax()
        {
            _monsterProperty.Hp = _monsterProperty.MaxHp;
            _monsterProperty.Mp = _monsterProperty.MaxMp;
        }
        #endregion
    }
}
