﻿using Behaviors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using Controllers;

namespace Global
{
    public static class  GetGlobalObjects
    {
        public static Cooldowns getCooldownsInstance()
        {
            GameObject globalVariables = GameObject.FindGameObjectsWithTag(GlobalTags.GLOBAL_VARIABLES)[0];
            GlobalStartup global = globalVariables.GetComponent<GlobalStartup>();
            Cooldowns cooldowns = global.cooldowns;
            return cooldowns;
        }

        public static GameState getGameState()
        {
            GameObject globalGameState = GameObject.FindGameObjectsWithTag(GlobalTags.GAME_STATE)[0];
            GameState gameState = globalGameState.GetComponent<GameState>();
            return gameState;
        }

        public static GameObject[] getPlayerArray()
        {
            return GameObject.FindGameObjectsWithTag(GlobalTags.PLAYER);
        }

        public static GameObject getPlayer(int playerNum)
        {
            return getGameState().getPlayer(playerNum);
        }

        public static GameObject getControllablePlayer()
        {
            foreach(GameObject player in getGameState().getAllPlayers())
            {
                if (player.GetComponent<PlayerController>().IsControlledPlayer)
                {
                    return player;
                }
            }
            return null;
        }
    }
}