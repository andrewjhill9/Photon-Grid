﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Global
{
    public static class GlobalTags
    {
        #region UI

        public static readonly string NUM_AI_SLIDER = "NumAI Slider";
        public static readonly string COLOR_SLIDER = "Color Slider";
        public static readonly string CAMERA = "MainCamera";
        public static readonly string MAX_HUMANS_SLIDER = "Max Humans Slider";

        #endregion

        #region Network

        public static readonly string NETWORK_MANAGER = "Network Manager";
        public static readonly string SPAWN_POSITION = "Spawn Position";
        public static readonly string LOBBY_MANAGER = "Lobby Manager";
        

        #endregion

        #region Scenes

        public static readonly string LOADING_SCREEN = "Loading Screen Menu";
        public static readonly string GAME_SCREEN = "Game Scene";
        public static readonly int GAME_SCREEN_NUM = 10;
        public static readonly int LOBBY_SCREEN_NUM = 11;

        #endregion

        #region Game Settings

        public static readonly string GAME_SETTINGS_OBJECT = "Game Settings";

        #endregion

        #region Prefab Names

        public static readonly string BOUNDARY = "Boundary";
        //public static readonly string 
        public static readonly string WALL_PREFAB = "Prefabs/Player-Related/Wall";

        #endregion

        
        #region Tags

        public static readonly string WALL_TAG = "Wall";

        #endregion


        public static readonly string GLOBAL_VARIABLES = "GlobalVariables";
        public static readonly string AIMANAGER = "AIManager";
        public static readonly string PLAYER = "Player";
        public static readonly string GAME_STATE = "GameState";
        public static readonly string[] PLAYERS = { "Player 0", "Player 1", "Player 2", "Player 3", "Player 4", "Player 5", "Player 6", "Player 7" };
        public static readonly string[] PLAYER_COLORS = { "Blue", "Red", "Orange", "Yellow", "Purple", "Pink", "Green", "White" };
        public static readonly string PLAYER0 = "Player 0";
        public static readonly string PLAYER1 = "Player 1";
        public static readonly string PLAYER2 = "Player 2";
        public static readonly string PLAYER3 = "Player 3";
        public static readonly string PLAYER4 = "Player 4";
        public static readonly string PLAYER5 = "Player 5";
        public static readonly string PLAYER6 = "Player 6";
        public static readonly string PLAYER7 = "Player 7";
    }
}
