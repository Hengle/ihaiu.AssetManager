﻿using UnityEngine;
using System.Collections;
using UnityEditor;

namespace Games
{
    public class GameMenuItems 
    {
        [MenuItem("游戏/Generator game_const.json", false,100)]
        public static void Generator()
        {
            GameConstConfig obj = new GameConstConfig();
            obj.Save();
        }
    }
}
