using DragonQuestWFA.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DragonQuestWFA.Engine
{
    public class CharactorVictoryState : AbstractBattleState
    {
        public override void Initail(BattleEvents events)
        {
            events.CharactorVictoryState += Execute;
        }

        public override void Execute(BattleEventArgs args)
        {
            IBattleGroup group = args.BattleGroup;

            if (group.Charactor.Count == 0) return;

            List<object> _data = GetMsgData(group);

            args.Data = _data;
        }

        private List<object> GetMsgData(IBattleGroup group)
        {
            List<object> _data = new List<object>();
            //資料整理
            foreach (ICharactorProperty charactor in group.Charactor)
            {
                _data.Add(new { charactor.Name, charactor.Hp });
            }
            return _data;
        }
    }
}
