using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonQuestWFA.Common
{
    public interface IGameEvent
    {
        event GameEventHandler _gameEvent;
    }
}
