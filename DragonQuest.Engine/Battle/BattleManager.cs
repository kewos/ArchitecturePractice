using DragonQuestWFA.Service;
using DragonQuestWFA.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DragonQuestWFA.Engine
{
    public interface IBattleProcess
    {
        void Excute(BattleManager manager);
    }

    public class BattleManager : IBattleManager
    {
        public event GameEventHandler _gameEvent;
        protected IMsgCollector _msgCollector;
        protected BattleEvents _events;
        protected IBattleGroup _group;
        protected BattleEventArgs _args;
        protected List<IBattleProcess> _battleProcesses;

        public BattleManager(IConfigurationFactory factory, IBattleGroup group)
        {
            _events = factory.GetEvents();
            _msgCollector = ServiceLocator.GetServiceLocator().GetService<IMsgCollector>();
            _group = group;
            _args = new BattleEventArgs(group);
            //建立戰鬥程序
            InitailBattleProcess();
        }

        private void InitailBattleProcess()
        {
            _battleProcesses = new List<IBattleProcess>();
            _battleProcesses.Add(new CharactorDieProcess());
            _battleProcesses.Add(new MonsterDieProcess());
            _battleProcesses.Add(new CharactorWinProcess());
            _battleProcesses.Add(new MonsterWinProcess());
            _battleProcesses.Add(new StartBattleProcess());
        }

        public void Battle()
        {
            try
            {
                while (true)
                {
                    _battleProcesses.ForEach(currentProcess =>
                        {
                            currentProcess.Excute(this);
                        });
                }
            }
            catch (Exception e){ }
            finally
            {
                ReleaseMsg();
            }
        }

        public void ReleaseMsg()
        {
            if (_gameEvent != null)
                _gameEvent(_msgCollector.GetMsgAndClear());
        }

        private class StartBattleProcess : IBattleProcess
        {
            public void Excute(BattleManager manager)
            {
                //違反迪米特法則
                if (manager._group.Monster.Count <= 0 && manager._group.Charactor.Count <= 0) return;
                
                manager._events.BattleState(manager._args);
                manager._msgCollector.SaveMsg<ResultDamageMsg>(manager._args.Data);
            }
        }

        private class CharactorWinProcess : IBattleProcess
        {
            public void Excute(BattleManager manager)
            {
                if (manager._group.Monster.Count <= 0)
                {
                    manager._events.CharactorVictoryState(manager._args);
                    manager._msgCollector.SaveMsg<CharactorVictoryMsg>(manager._args.Data);
                    throw new Exception();
                }
            }
        }

        private class MonsterWinProcess : IBattleProcess
        {
            public void Excute(BattleManager manager)
            {
                if (manager._group.Charactor.Count <= 0)
                {
                    manager._events.MonsterVictoryState(manager._args);
                    manager._msgCollector.SaveMsg<MonsterVictoryMsg>(manager._args.Data);
                    throw new Exception();
                }
            }
        }

        private class MonsterDieProcess : IBattleProcess
        {
            public void Excute(BattleManager manager)
            {
                if (manager._group.DieMonster.Count > 0)
                {
                    manager._events.MonsterDieState(manager._args);
                    manager._msgCollector.SaveMsg<MonsterDieMsg>(manager._args.Data);

                    manager._events.DropItemState(manager._args);
                    manager._msgCollector.SaveMsg<DropItemMsg>(manager._args.Data);

                    manager._events.RaiseExpState(manager._args);
                    manager._msgCollector.SaveMsg<UpgradeLevelMsg>(manager._args.Data);

                    manager._group.DieMonster.Clear();
                }
            }
        }

        private class CharactorDieProcess : IBattleProcess
        {
            public void Excute(BattleManager manager)
            {
                if (manager._group.DieCharactor.Count > 0)
                {
                    manager._events.CharactorDieState(manager._args);
                    manager._group.DieCharactor.Clear();
                    manager._msgCollector.SaveMsg<CharactorDieMsg>(manager._args.Data);
                }
            }
        }
    }
}
