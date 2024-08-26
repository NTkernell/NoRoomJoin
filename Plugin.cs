using BepInEx;
using Photon.Pun;
using System;
using UnityEngine;
using Utilla;

namespace TestMod
{
   

    
    [ModdedGamemode]
    [BepInDependency("org.legoandmars.gorillatag.utilla", "1.5.0")]
    [BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
    public class Plugin : BaseUnityPlugin
    {
        bool inRoom;

        void Start()
        {
            
            
            Utilla.Events.GameInitialized += OnGameInitialized;
        }

        void OnEnable()
        {
            
           
            HarmonyPatches.ApplyHarmonyPatches();
        }

        void OnDisable()
        {
           
           

            HarmonyPatches.RemoveHarmonyPatches();
        }

        void OnGameInitialized(object sender, EventArgs e)
        {
            

            PhotonNetwork.LeaveRoom();

        }

        void Update()
        {
            

            PhotonNetwork.LeaveRoom();

        }

       
        [ModdedGamemodeJoin]
        public void OnJoin(string gamemode)
        {
           

            PhotonNetwork.LeaveRoom();

            inRoom = true;
        }

        
        [ModdedGamemodeLeave]
        public void OnLeave(string gamemode)
        {
           

            PhotonNetwork.LeaveRoom();

            inRoom = false;
        }
    }
}
