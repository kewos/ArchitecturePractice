using DragonQuestWFA.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DragonQuestWFA.Engine
{
    public interface IConfigurationFactory
    {
        BattleEvents GetEvents();
    }

    public class ConfigurationFactory : IConfigurationFactory
    {
        private BattleEvents events;

        public ConfigurationFactory()
        {
            DragonQuestEngineConfigurationSection config = ConfigurationManager.GetSection("dragonQuestEngine") as DragonQuestEngineConfigurationSection;
            
            if (config != null)
            {
                events = new BattleEvents();

                foreach (ProviderSettings moduleElement in config.Modules)
                {
                    IBattleState state = Activator.CreateInstance(Type.GetType(moduleElement.Type)) as IBattleState;
                    state.Initail(events);
                }
            }
        }

        public BattleEvents GetEvents()
        {
            return events;
        }
    }
}
