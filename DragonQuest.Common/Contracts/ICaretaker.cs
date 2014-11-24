using System;
using System.Collections.Generic;

namespace DragonQuestWFA.Common
{
    public interface ICaretaker
    {
        //存檔區
        IMemento Memento { get; set; }
    }
}
