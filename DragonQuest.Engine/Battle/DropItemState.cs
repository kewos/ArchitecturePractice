using DragonQuestWFA.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DragonQuestWFA.Engine
{
    public class DropItemState : AbstractBattleState
    {
        public override void Initail(BattleEvents events)
        {
            events.DropItemState += Execute;
        }

        public override void Execute(BattleEventArgs args)
        {
            IBattleGroup group = args.BattleGroup;

            if (group.DieMonster.Count == 0) return;

            List<object> _data = GetMsgData(group);

            args.Data = _data;
        }

        private List<object> GetMsgData(IBattleGroup group)
        {
            List<object> _data = new List<object>();
            //資料整理
            foreach (IMonsterProperty _peroperty in group.DieMonster)
            {
                List<string> itemList = 
                    ObjectFactory.GetInstance<IMonsterProperty, MonsterBehavior>(_peroperty).DropItems();
                itemList.ForEach(item => _data.Add(item));
            }

            return _data;
        }
    }
}
