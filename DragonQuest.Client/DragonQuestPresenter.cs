using DragonQuestWFA.Service;
using DragonQuestWFA.Engine;
using DragonQuestWFA.Common;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using Microsoft.Practices.Unity;

namespace DragonQuestWFA.Client
{
    public class DragonQuestPresenter
    {
        static DragonQuestPresenter _presenter = null;
        private GameReposity _gameReposity;
        private IMsgCollector _collector;
        private Dictionary<object, IView> _views;

        private DragonQuestPresenter() 
        {
            _collector = ServiceLocator.GetServiceLocator().GetService<IMsgCollector>();
            _gameReposity = GameReposity.GetInstance();
        }

        public static DragonQuestPresenter GetInstance()
        {
            if (_presenter == null) _presenter = new DragonQuestPresenter();
            return _presenter;
        }

        public void RegistView<TView>(TView view)
            where TView : IView
        {
            if (_views == null) _views = new Dictionary<object,IView>();
            _views.Add(typeof(TView), view);
        }

        /// <summary>
        /// 取得角色攻擊的結果
        /// </summary>
        /// <param name="charactorIndex">角色引數</param>
        public void Attack<TView>(int index)
        {
            ICharactorProperty _property = _gameReposity.GetIndexOfCharactor(index);
            ICharactorBehavior _charactor = 
                ObjectFactory.GetInstance<ICharactorProperty, CharactorBehavior>(_property, _collector);
            _charactor._gameEvent += new GameEventHandler(_views[typeof(TView)].Show);
            _charactor.Attack();
        }

        /// <summary>
        /// 取得角色展示的結果
        /// </summary>
        /// <param name="index">角色引數</param>
        public void DisplayState<TView>(int index)
        {
            ICharactorProperty _property = _gameReposity.GetIndexOfCharactor(index);
            ICharactorBehavior _charactor =
                ObjectFactory.GetInstance<ICharactorProperty, CharactorBehavior>(_property, _collector);
            _charactor._gameEvent += new GameEventHandler(_views[typeof(TView)].Show);
            _charactor.DisplayState();
        }

        /// <summary>
        /// 取得角色名稱列表
        /// </summary>
        public List<string> GetCharactorNames()
        {
            return _gameReposity.GetCharactorNames().ToList<string>();
        }

        /// <summary>
        /// 取得地圖名稱列表
        /// </summary>
        public List<string> GetMapNames()
        {
            return _gameReposity.GetMapNames().ToList<string>();
        }

        public void Initial<TView>()
        {
            _gameReposity._gameEvent += new GameEventHandler(_views[typeof(TView)].Show);
            _gameReposity.CreateCharactor();
        }

        /// <summary>
        /// 取得戰鬥結果訊息
        /// </summary>
        /// <param name="mapIndex">地圖引數</param>
        public void Expedition<TView>(int mapIndex)
        {
            //取得地圖
            IMapProperty _mapProperty = _gameReposity.GetIndexOfMap(mapIndex);
            //取得怪物列表
            List<string> _monsterList = 
                ObjectFactory.GetInstance<IMapProperty, MapBehavior>(_mapProperty).ProduceMonsterList();

            BuildBattle<TView>(_monsterList);
        }

        private void BuildBattle<TView>(List<string> _monsterList)
        {
            //建立戰鬥
            var container = new UnityContainer();
            container.RegisterType<IBattleGroup, BattleGroup>();
            //取得戰鬥所需資訊
            IBattleGroup group = container.Resolve<IBattleGroup>();
            group.DieCharactor = new List<ICharactorProperty>();
            group.DieMonster = new List<IMonsterProperty>();
            group.Charactor = _gameReposity.GetCharactor();
            group.Monster = _gameReposity.GetMatchMonsters(_monsterList).ToList<IMonsterProperty>();

            container.RegisterType<IConfigurationFactory, ConfigurationFactory>();
            IConfigurationFactory factory = container.Resolve<IConfigurationFactory>();

            container.RegisterType<IBattleManager, BattleManager>(new InjectionConstructor(factory, group));
            IBattleManager _battle = container.Resolve<IBattleManager>();
            _battle._gameEvent += new GameEventHandler(_views[typeof(TView)].Show);
            _battle.Battle();
        }
    }
}
