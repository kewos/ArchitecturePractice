using DragonQuestWFA.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DragonQuestWFA.Client
{
    class Skill : ISkill 
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Mana{ get; set; }
        public List<IBuff> Buff { get; set; }
        public int DamagePercentage { get; set; }
        public int Damage { get; set; }
        public int Range { get; set; }

        Dictionary<string, object> ISkill.Cast()
        {
            return new Dictionary<string, object>()
            {
                { "Name", Name },
                { "Mana", Mana },
                { "DamagePercentage", DamagePercentage },
                { "Damage", Damage },
                { "Range", Range },
            };
        }
    }
}
