using System;
using System.Collections.Generic;

namespace DragonQuestWFA.Common
{
    public interface IEquipment : IDescription, IItem
    {
        List<string> JobLimit { get; set; }
        int LevelLimit { get; set; }
        int Atk { get; set; }
        int Def { get; set; }
        int Speed { get; set; }
        int Hp { get; set; }
        int Mp { get; set; }
    }
}
