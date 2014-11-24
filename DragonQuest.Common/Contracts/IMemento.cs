using System;
using System.Collections.Generic;

namespace DragonQuestWFA.Common
{
    public interface IMemento
    {
        //怪物檔案
        List<IMonsterProperty> Monsters { get; set; }
        //地圖檔案
        List<IMapProperty> Maps { get; set; }
        //角色檔案
        List<ICharactorProperty> Charactors { get; set; }
        //存怪物資料
        IMemento SaveMonsters(List<IMonsterProperty> monsters);
        //存地圖資料
        IMemento SaveMaps(List<IMapProperty> maps);
        //存角色資料
        IMemento SaveCharactors(List<ICharactorProperty> charactors);
    }
}
