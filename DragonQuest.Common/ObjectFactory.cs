using DragonQuestWFA.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Xml.Serialization;
using System.IO;

namespace DragonQuestWFA.Common
{
    public class ObjectFactory
    {
        public static T GetInstance<T>() where T : class
        {
            return (T)Activator.CreateInstance(typeof(T));
        }

        public static TBehavior GetInstance<TProperty, TBehavior>(TProperty obj) 
            where TProperty : class
            where TBehavior : class
        {
            return (TBehavior)Activator.CreateInstance(typeof(TBehavior), obj);
        }

        public static TBehavior GetInstance<TProperty, TBehavior>(TProperty obj, IMsgCollector collector)
            where TProperty : class
            where TBehavior : class
        {
            return (TBehavior)Activator.CreateInstance(typeof(TBehavior), obj, collector);
        }
    }
}
