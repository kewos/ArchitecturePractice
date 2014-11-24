using DragonQuestWFA.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DragonQuestWFA.Common
{
    public abstract class MsgTemplate : IMsgTemplate
    {
        public abstract string ProduceMsg(List<object> args);

        public string GetMsg(List<object> data)
        {
            if (data == null || data.Count == 0) return null;

            return ProduceMsg(data);
        }
    }

    public class AttackMsg : MsgTemplate
    {
        public override string ProduceMsg(List<object> data)
        {
             return string.Format("{0}使用{1}造成{2}點傷害！！\n", data.ToArray());
        }
    }

    public class WalkMsg : MsgTemplate
    {
        public override string ProduceMsg(List<object> data)
        {
            return string.Format("{0}移動速度{1}\n", data.ToArray());
        }
    }

    public class DisPlayStateMsg : MsgTemplate
    {
        public override string ProduceMsg(List<object> data)
        {
            return string.Format(
                    "名稱：{0}\n等級：{1}\n攻擊力：{2}\n防禦：{3}\n速度{4}\n血量：{5}\\{6}\n魔力：{7}\\{8}\n武器：{9}\n", 
                    data.ToArray()
                );
        }
    }

    public class MonsterDieMsg : MsgTemplate
    {
        public override string ProduceMsg(List<object> data)
        {
            StringBuilder _msg = new StringBuilder();

            foreach (object arg in data)
            {
                _msg.AppendFormat("[{0}]被殺死了\n", arg);
            }

            return _msg.ToString();
        }
    }

    public class DropItemMsg : MsgTemplate
    {
        public override string ProduceMsg(List<object> data)
        {
            StringBuilder _msg = new StringBuilder();

            _msg.Append("****************戰利品*****************\n");
            foreach (object arg in data)
            {
                _msg.AppendFormat("[{0}]\n", arg);
            }
            _msg.Append("****************戰利品*****************\n");

            return _msg.ToString();
        }
    }

    public class ResultDamageMsg : MsgTemplate
    {
        public override string ProduceMsg(List<object> data)
        {
            StringBuilder _msg = new StringBuilder();

            _msg.Append("回合開始\n");

            foreach (object[] args in data)
            {
                _msg.AppendFormat("[{0}]造成[{1}]{2}傷害！！{3}還有{4}點生命\n", args);
            }

            _msg.Append("回合結束\n");

            return _msg.ToString();
        }
    }

    public class CharactorDieMsg : MsgTemplate
    {
        public override string ProduceMsg(List<object> data)
        {
            StringBuilder _msg = new StringBuilder();

            foreach (string name in data)
            {
                _msg.AppendFormat("{0}被擊倒了\n", name);
            }

            return _msg.ToString();
        }
    }

    public class CharactorVictoryMsg : MsgTemplate
    {
        public override string ProduceMsg(List<object> data)
        {
            StringBuilder _msg = new StringBuilder();
            _msg.Append("============================================\n");
            _msg.Append("遠征軍擊倒了怪物大軍\n");

            foreach (object[] args in data)
            {
                _msg.AppendFormat("[{0}]還有{1}點生命\n", args);
            }

            return _msg.ToString();
        }
    }

    public class MonsterVictoryMsg : MsgTemplate
    {
        public override string ProduceMsg(List<object> data)
        {
            StringBuilder _msg = new StringBuilder();
            _msg.Append("============================================\n");
            _msg.Append("怪物大軍擊倒了遠征軍\n");

            foreach (object[] args in data)
            {
                _msg.AppendFormat("[{0}]還有{1}點生命\n", args);
            }

            return _msg.ToString();
        }
    }

    public class UpgradeLevelMsg : MsgTemplate
    {
        public override string ProduceMsg(List<object> data)
        {
            StringBuilder _msg = new StringBuilder();

            foreach (object[] args in data)
            {
                _msg.AppendFormat("[{0}]升級了目前等級為{1}\n", args);
            }

            return _msg.ToString();
        }
    }

    public class CurrentHpMsg : MsgTemplate
    {
        public override string ProduceMsg(List<object> data)
        {
            return string.Format("[{0}]還有{1}點生命\n", data.ToArray());
        }
    }

    public class LevelUpMsg : MsgTemplate
    {
        public override string ProduceMsg(List<object> data)
        {
            return string.Format("[{0}]升級了目前等級為{1}\n", data.ToArray());
        }
    }
}
