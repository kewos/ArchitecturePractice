using DragonQuestWFA.Common;
using DragonQuestWFA.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DragonQuestWFA.Engine
{
    public partial class GameReposity
    {
        public event GameEventHandler _gameEvent = null;
        private static GameReposity _gameContainer;

        public static GameReposity GetInstance()
        {
            if (_gameContainer == null)
            {
                _gameContainer = new GameReposity();
            }

            return _gameContainer;
        }

        private GameReposity()
        {
            CreateMap();
            CreateCharactor();
            CreateMonster();
        }
    }
}
