using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PunchingMod
{
    [BepInPlugin(modGUID, modName, modVersion)]
    public class PunchingMod : BaseUnityPlugin
    {
        private const string modGUID = "StretchySpaghetti.PunchingMod";
        private const string modName = "Punching Mod";
        private const string modVersion = "1.0.0";

        private readonly Harmony harmony = new Harmony(modGUID);

        private static PunchingMod Instance;

        internal ManualLogSource manualLogSource;


        // Entry point 
        void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }

            manualLogSource = BepInEx.Logging.Logger.CreateLogSource(modGUID);

            manualLogSource.LogInfo("Starting up PunchingMod");

            harmony.PatchAll(); // patches mod


        }

    }
}
