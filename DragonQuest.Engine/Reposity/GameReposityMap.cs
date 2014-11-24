using DragonQuestWFA.Common;
using DragonQuestWFA.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DragonQuestWFA.Engine
{
    //地圖
    public partial class GameReposity
    {
        private List<IMapProperty> _mapList = new List<IMapProperty>();

        public void CreateMap()
        {
            _mapList.Clear();
            _mapList.AddRange(SerializableObjectFactory.GetInstance<MapProperty>());
        }

        public List<IMapProperty> GetMap()
        {
            return _mapList;
        }

        public IEnumerable<string> GetMapNames()
        {
            return _mapList.Select(_map => _map.Name);
        }

        public IMapProperty GetIndexOfMap(int index)
        {
            return _mapList[index];
        }
    }
}
