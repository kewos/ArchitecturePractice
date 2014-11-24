using DragonQuestWFA.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DragonQuestWFA.Engine
{
    public class MonsterVictoryState : AbstractBattleState
    {
        public override void Initail(BattleEvents events)
        {
            events.MonsterVictoryState += Execute;
        }

        public override void Execute(BattleEventArgs args)
        {
            IBattleGroup group = args.BattleGroup;

            if (group.Monster.Count <= 0) return;

            List<object> _data = GetMsgData(group);

            args.Data = _data;
        }

        private List<object> GetMsgData(IBattleGroup group)
        {
            List<object> _data = new List<object>();
            //資料整理
            foreach (IMonsterProperty _monsterProperty in group.Monster)
            {
                object[] args = { _monsterProperty.Name, _monsterProperty.Hp };
                _data.Add(args);
            }

            return _data;
        }
    }
}
