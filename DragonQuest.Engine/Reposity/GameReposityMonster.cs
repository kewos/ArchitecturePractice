using DragonQuestWFA.Common;
using DragonQuestWFA.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DragonQuestWFA.Engine
{
    //怪物
    public partial class GameReposity
    {
        private List<IMonsterProperty> _monsterList = new List<IMonsterProperty>();

        public void CreateMonster()
        {
            _monsterList.Clear();
            _monsterList.AddRange(SerializableObjectFactory.GetInstance<MonsterProperty>());
        }

        public List<IMonsterProperty> GetMonster()
        {
            return _monsterList;
        }

        public IEnumerable<IMonsterProperty> GetMatchMonsters(List<string> list)
        {
            return _monsterList.Where(_monster => list.Contains(_monster.Name));
        }
    }
}
