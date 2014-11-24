using DragonQuestWFA.Common;
using DragonQuestWFA.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DragonQuestWFA.Engine
{
    //角色
    public partial class GameReposity
    {
        private List<ICharactorProperty> _charactorList = new List<ICharactorProperty>();

        public void CreateCharactor()
        {
            _charactorList.Clear();
            _charactorList.AddRange(SerializableObjectFactory.GetInstance<CharactorProperty>());

            if (_gameEvent != null)
            {
                _gameEvent("初始成功！！！\n");
            } 
        }

        public List<ICharactorProperty> GetCharactor()
        {
            return _charactorList;
        }

        public IEnumerable<string> GetCharactorNames()
        {
            return _charactorList.Select(_charactor => _charactor.Name);
        }

        public ICharactorProperty GetIndexOfCharactor(int index)
        { 
            return _charactorList[index];
        }
    }
}
