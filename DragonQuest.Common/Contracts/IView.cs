using System;
using System.Collections.Generic;

namespace DragonQuestWFA.Common
{
    /*
     * 不同View對Presenter
     * */
    public interface IView
    {
        //訊息呈現
        void Show(string result);
    }
}
