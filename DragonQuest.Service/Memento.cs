using DragonQuestWFA.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DragonQuestWFA.Service
{
    /*public class GameCaretaker : ICaretaker
    {
        public IMemento Memento { get; set; }
    }

    public class GameMemoto : IMemento
    {
        #region IMemento 屬性
        public List<IMonsterProperty> Monsters { get; set; }
        public List<IMapProperty> Maps { get; set; }
        public List<ICharactorProperty> Charactors { get; set; }
        #endregion

        public IMemento SaveCharactors(List<ICharactorProperty> charactors)
        {
            Charactors = new List<ICharactorProperty>();
            charactors.ForEach(
                _item => Charactors.Add(
                    ObjectFactory.GetInstance<ICharactorProperty, CharactorBehavior>(_item).Clone()
                    )
                );

            return this;
        }

        public IMemento SaveMaps(List<IMapProperty> maps)
        {
            Maps = new List<IMapProperty>();
            maps.ForEach(_item => Maps.Add(ObjectFactory.GetInstance<IMapProperty, MapBehavior>(_item).Clone()));
            return this;
        }

        public IMemento SaveMonsters(List<IMonsterProperty> monsters)
        {
            Monsters = new List<IMonsterProperty>();
            monsters.ForEach(
                _item => Monsters.Add(
                    ObjectFactory.GetInstance<IMonsterProperty, MonsterBehavior>(_item).Clone()
                    )
                );
            return this;
        }
    }*/
}
