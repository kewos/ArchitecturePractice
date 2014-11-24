using DragonQuestWFA.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Xml.Serialization;

namespace DragonQuestWFA.Common
{
    public class MapBehavior : IMapBehavior
    {
        IMapProperty _mapProperty;

        public MapBehavior(IMapProperty mapProperty)
        {
            _mapProperty = mapProperty;
        }

        #region Map行為
        public List<string> ProduceMonsterList()
        {
            List<string> _monsterList = new List<string>();
            Random _random = new Random();
            //產生一個介於最大值與最小值之間的數字做為產生怪物數量的依據
            int _monsterNum = _random.Next(_mapProperty.MinMonsterNum, _mapProperty.MaxMonsterNum);

            while (_monsterList.Count < _monsterNum)
            {
                foreach (KeyValuePair<string, int> pair in _mapProperty.MonsterList)
                {
                    if (pair.Value >= _random.Next(0, 100))
                    {
                        _monsterList.Add(pair.Key);
                    }

                    if (_monsterList.Count >= _monsterNum) break;
                }
            }

            return _monsterList;
        }

        public void TargetEventProbability()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
