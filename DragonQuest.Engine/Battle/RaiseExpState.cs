using DragonQuestWFA.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DragonQuestWFA.Engine
{
    public class RaiseExpState : AbstractBattleState
    {
        public override void Initail(BattleEvents events)
        {
            events.RaiseExpState += Execute;
        }

        public override void Execute(BattleEventArgs args)
        {
            IBattleGroup group = args.BattleGroup;

            if (group.DieMonster.Count == 0) throw new Exception();

            int _earnExp = GetEarnExp(group);

            List<object> _data = CharactorRaiseExp(group, _earnExp);

            args.Data = _data;
        }

        /**
         * 計算每位角色所取得的經驗值
         * */
        private int GetEarnExp(IBattleGroup group)
        {
            int _exp = 0;
            //本次取得的全部經驗量
            group.DieMonster.ForEach(_monster => _exp += _monster.Exp);

            return _exp / group.Charactor.Count;
        }

        /**
         * 角色取得經驗值
         * */
        private List<object> CharactorRaiseExp(IBattleGroup group, int earnExp)
        {
            List<object> _data = new List<object>();
            foreach (ICharactorProperty _charactor in group.Charactor)
            {
                _charactor.Exp += earnExp;
                while (CanUpgradeLV(_charactor))
                {
                    IMsgCollector _collector = Service.ServiceLocator.GetServiceLocator().GetService<IMsgCollector>();
                    ObjectFactory.GetInstance<ICharactorProperty, CharactorBehavior>(_charactor, _collector).UpgradeLevel();
                    //資料整理
                    object[] args = { _charactor.Name, _charactor.Lv };
                    _data.Add(args);
                }
            }

            return _data;
        }

        private bool CanUpgradeLV(ICharactorProperty _charactor)
        {
            return (_charactor.Exp >= _charactor.Lv * _charactor.Lv * _charactor.Lv);
        }
    }
}
