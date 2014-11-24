using DragonQuestWFA.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DragonQuestWFA.Service
{
    public class ServiceLocator : IServiceLocator
    {
        private static IServiceLocator _serviceLocator;
        private static object _lock = new object();
        //存放服務
        private Dictionary<object, object> _services = new Dictionary<object, object>();

        private ServiceLocator()
        {
            //增加服務物件
            _services = new Dictionary<object, object>();
            RegisterService<IMsgCollector, MsgCollector>(ObjectFactory.GetInstance<MsgCollector>());
        }

        public static IServiceLocator GetServiceLocator()
        {
            lock (_lock)
            {
                if (_serviceLocator == null)
                    _serviceLocator = new ServiceLocator();
            }
            return _serviceLocator;
        }

        public void RegisterService<TInterface, TType>(TType obj)
            where TType : TInterface
        {
            _services.Add(typeof(TInterface), obj);
        }

        public void RegisterService<TType>(TType obj)
        {
            _services.Add(typeof(TType), obj);
        }

        public T GetService<T>()
        {
            try
            {
                return (T)_services[typeof(T)];
            }
            catch (Exception)
            {
                throw new ArgumentException("不符合的型別");
            }
        }
    }
}
