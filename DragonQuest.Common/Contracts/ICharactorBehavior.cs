using System;
using System.Collections.Generic;

namespace DragonQuestWFA.Common
{
    public interface ICharactorBehavior : IGameEvent
    {
        #region 角色行為
        //展示攻擊
        void Attack();
        //展示屬性
        void DisplayState();
        //升級時所會發生的屬性變動
        void UpgradeLevel();
        //設定生命法力為最大值
        void SetHpMpMax();
        #endregion
    }
}
