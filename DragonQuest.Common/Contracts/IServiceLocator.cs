using System;
using System.Collections.Generic;

namespace DragonQuestWFA.Common
{
    public interface IServiceLocator
    {
        //取得服務物件
        T GetService<T>();
        //註冊服務
        void RegisterService<TInterface, TType>(TType obj) where TType : TInterface;
        void RegisterService<TType>(TType obj);
    }
}
