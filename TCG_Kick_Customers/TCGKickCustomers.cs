using BepInEx;
using BepInEx.Logging;
using UnityEngine;

namespace TCGKickCustomers
{
    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    public class TCGKickCustomersPlugin : BaseUnityPlugin
    {
        private static TCGKickCustomersPlugin? Instance;
        internal static ManualLogSource? Log;

        private void Awake()
        {
            // Plugin startup logic
            Instance = this;
            Log = Logger;

            Log?.LogInfo($"Plugin {PluginInfo.PLUGIN_GUID} is loaded!");

            // Add your plugin initialization code here
        }

        // Add more methods and functionality for your mod here
    }

    internal static class PluginInfo
    {
        public const string PLUGIN_GUID = "com.yourname.tcgkickcustomers";
        public const string PLUGIN_NAME = "TCG Kick Customers";
        public const string PLUGIN_VERSION = "1.0.0";
    }
}
