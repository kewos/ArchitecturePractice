using DragonQuestWFA.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Xml.Serialization;


namespace DragonQuestWFA.Common
{
    public class CharactorBehavior : ICharactorBehavior
    {
        public event GameEventHandler _gameEvent = null;
        ICharactorProperty _charactorProperty;
        IMsgCollector _msgCollector;

        public CharactorBehavior(ICharactorProperty charactorProperty, IMsgCollector msgCollector)
        {
            this._charactorProperty = charactorProperty;
            this._msgCollector = msgCollector;
        }

        public void Attack()
        {
            string _msg = _msgCollector.InflateMsgAndGet<AttackMsg>(new List<object>()
            { 
                _charactorProperty.Name, 
                (_charactorProperty.Weapon != null) ? _charactorProperty.Weapon.Name : "空手", 
                _charactorProperty.Atk 
            });

            if (_gameEvent != null) _gameEvent(_msg);
        }

        public void DisplayState()
        {
            //訊息整理
            string _msg = _msgCollector.InflateMsgAndGet<DisPlayStateMsg>(new List<object> 
            { 
                _charactorProperty.Name, 
                _charactorProperty.Lv, 
                (_charactorProperty.Atk >= 0) ? _charactorProperty.Atk : 0,
                (_charactorProperty.Def >= 0) ? _charactorProperty.Def : 0,
                (_charactorProperty.Speed >= 0) ? _charactorProperty.Speed : 0, 
                (_charactorProperty.MaxHp >= 0) ? _charactorProperty.MaxHp : 0,
                (_charactorProperty.Hp >= 0) ? _charactorProperty.Hp : 0,
                (_charactorProperty.MaxMp >= 0) ? _charactorProperty.MaxMp : 0,
                (_charactorProperty.Mp >= 0) ? _charactorProperty.Mp : 0,
                (_charactorProperty.Weapon != null) ? _charactorProperty.Weapon.Name : "空手"
            });

            if (_gameEvent != null) _gameEvent(_msg);
        }

        public void SetHpMpMax()
        {
            _charactorProperty.Hp = _charactorProperty.MaxHp;
            _charactorProperty.Mp = _charactorProperty.MaxMp;
        }

        public void UpgradeLevel()
        {
            //lv ** 3為升級所需經驗值
            _charactorProperty.Exp -= _charactorProperty.Lv * _charactorProperty.Lv * _charactorProperty.Lv;
            _charactorProperty.Lv++;

            //升級級距
            int _upgradeRange = (_charactorProperty.Lv / 10) + 1;

            _charactorProperty.Atk += _upgradeRange * _charactorProperty.UpgradeAtk;
            _charactorProperty.Def += _upgradeRange * _charactorProperty.UpgradeDef;
            _charactorProperty.Speed += _upgradeRange * _charactorProperty.UpgradeSpeed;
            _charactorProperty.MaxHp += _upgradeRange * _charactorProperty.UpgradeMaxHp;
            _charactorProperty.MaxMp += _upgradeRange * _charactorProperty.UpgradeMaxMp;

            //生命魔力補滿
            SetHpMpMax();
        }
    }
}
