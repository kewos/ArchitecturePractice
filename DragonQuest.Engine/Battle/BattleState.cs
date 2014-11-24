using DragonQuestWFA.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DragonQuestWFA.Engine
{
    public class BattleState : AbstractBattleState
    {
        Random random = new Random();
        List<IUnitProperty> _battleQueue;
        List<object> _data = new List<object>();
        IBattleGroup _battleGroup;

        public override void Initail(BattleEvents events)
        {
            events.BattleState += Execute;
        }

        public override void Execute(BattleEventArgs args)
        {
            //初始狀態設定
            _battleGroup = args.BattleGroup;
            //排序戰鬥順序
            SortBattleUnit();
            //進入戰鬥
            BattleEachTurn();
            //回傳資料
            args.Data = _data;
        }

        # region 戰鬥細節
        private void BattleEachTurn()
        {  
            //每個單位分別執行戰鬥
            foreach (IUnitProperty _unit in _battleQueue
                .Where(unit => !(_battleGroup.Charactor.Count <= 0 || _battleGroup.Monster.Count <= 0))
            )
            {
                //進入戰鬥
                StartBattle(_unit);
            }
        }

        private void StartBattle(IUnitProperty attacker)
        {
            //取得隨機一名被攻擊的單位
            IUnitProperty attacked = GetAttedUnit(attacker);
            //攻擊者造成傷害
            var _atk = ResultDamage(attacker, attacked);
            //判斷被攻擊者是否死亡
            CheckIsDead(attacked);
            //收集資料
            CollectData(attacker, attacked, _atk);
        }

        private IUnitProperty GetAttedUnit(IUnitProperty attacker)
        {
            return (attacker is ICharactorProperty) ?
                GetAttacked<IMonsterProperty>() :
                GetAttacked<ICharactorProperty>();
        }

        private void CheckIsDead(IUnitProperty attacked)
        {
            if (attacked.Hp <= 0)
            {
                if (attacked is IMonsterProperty)
                {
                    _battleGroup.DieMonster.Add((IMonsterProperty)attacked);
                    _battleGroup.Monster.Remove((IMonsterProperty)attacked);
                }

                if (attacked is ICharactorProperty)
                {
                    _battleGroup.Charactor.Remove((ICharactorProperty)attacked);
                    _battleGroup.DieCharactor.Add((ICharactorProperty)attacked);
                }
            }
        }

        private void CollectData(IUnitProperty attacker, IUnitProperty attacked, int _atk)
        {
            object[] args = { attacker.Name, attacked.Name, _atk, attacked.Name, attacked.Hp };
            _data.Add(args);
        }

        private int ResultDamage(IUnitProperty _attack, IUnitProperty _attacked)
        {
            var _atk = (_attacked.Def >= _attack.Atk) ? 1 : _attack.Atk - _attacked.Def;
            _attacked.Hp -= _atk;

            return _atk;
        }

        private IUnitProperty GetAttacked<T>()
            where T : IUnitProperty
        {
            IUnitProperty _attacked = null;
            if (typeof(T) == typeof(ICharactorProperty))
            {
                _attacked = _battleGroup.Charactor[random.Next(0, _battleGroup.Charactor.Count - 1)];
            }

            if (typeof(T) == typeof(IMonsterProperty))
            {
                _attacked = _battleGroup.Monster[random.Next(0, _battleGroup.Monster.Count - 1)];
            }

            return _attacked;
        }

        private void SortBattleUnit()
        {
            _battleQueue = new List<IUnitProperty>();
            //將需要戰鬥的單位放到battl eueue
            _battleQueue.AddRange(_battleGroup.Charactor);
            _battleQueue.AddRange(_battleGroup.Monster);
            //依排序怪物角色的速度進行排序
            _battleQueue.Sort((x, y) => { return -x.Speed.CompareTo(y.Speed); });
        }
        # endregion 
    }
}
