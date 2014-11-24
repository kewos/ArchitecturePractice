using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DragonQuestWFA.Common
{
    public interface IWeapon
    {
        string Name { get; set; }
        int UnsteadyDamage { get; set; }
        int Damage { get; set; }
    }
}
