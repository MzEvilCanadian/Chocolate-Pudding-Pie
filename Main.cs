using ChocolatePuddingPie.Customs;
using ChocolatePuddingPie.Registry;
using ChocolatePuddingPie.Dishes;
using KitchenData;
using KitchenLib;
using KitchenLib.References;
using KitchenLib.Utils;
using KitchenMods;
using KitchenLib.Event;
using System.IO;
using System.Linq;
using System.Reflection;
using UnityEngine;
using System;
using ItemReference = KitchenLib.References.ItemReferences;

namespace ChocolatePuddingPie
{
    public class Main : BaseMod
    {
        internal const string MOD_ID = "ChocolatePuddingPie";
        internal const string MOD_NAME = "Chocolate Pudding Pie";
        internal const string MOD_VERSION = "1.0.0";
        internal const string MOD_AUTHOR = "MzEvilCanadian";
        public const string MOD_GAMEVERSION = ">=1.1.3";

        public static AssetBundle bundle;

        // Vanilla Processes
        internal static Process Cook => GetExistingGDO<Process>(ProcessReferences.Cook);
        internal static Process Chop => GetExistingGDO<Process>(ProcessReferences.Chop);
        internal static Process Knead => GetExistingGDO<Process>(ProcessReferences.Knead);

        // Vanilla Ingredients
        internal static Item Pot => GetExistingGDO<Item>(ItemReference.Pot);
        internal static Item Flour => GetExistingGDO<Item>(ItemReference.Flour);
        internal static Item PieCrust => GetExistingGDO<Item>(ItemReference.PieCrustCooked);

        // Modded Ingredients
        public static Item Chocolate => Find<Item>(IngredientLib.References.GetIngredient("chocolate"));
        public static Item ChocolateFilling => Find<Item>(IngredientLib.References.GetIngredient("chocolate sauce"));


        internal static ItemGroup ChocolatePuddingPieA => GetModdedGDO<ItemGroup, ChocolatePuddingPieA>();
        internal static Item ChocolatePuddingPieServing => GetModdedGDO<Item, ChocolatePuddingPieServing>();



        internal static bool debug = true;
        public static void LogInfo(string _log) { Debug.Log($"[{MOD_NAME}] " + _log); }
        public static void LogInfo(object _log) { LogInfo(_log.ToString()); }
        public static void LogError(string _log) { Debug.LogError($"[{MOD_NAME}] " + _log); }
        public static void LogError(object _log) { LogError(_log.ToString()); }

        public Main() : base(MOD_ID, MOD_NAME, MOD_AUTHOR, MOD_VERSION, $"{MOD_GAMEVERSION}", Assembly.GetExecutingAssembly())
        {
            string bundlePath = Path.Combine(new string[] { Directory.GetParent(Application.dataPath).FullName, "Mods", ModID });

            Debug.Log($"{MOD_NAME} {MOD_VERSION} {MOD_AUTHOR}: Loaded");
            Debug.Log($"Assets Loaded From {bundlePath}");
        }

        public override void PostActivate(KitchenMods.Mod mod)
        {

            base.PostActivate(mod);
            bundle = mod.GetPacks<AssetBundleModPack>().SelectMany(e => e.AssetBundles).ToList()[0];

                AddGameDataObject<ChocolatePuddingPieServing>();
                AddGameDataObject<ChocolatePuddingPieA>();
                AddGameDataObject<ChocolatePuddingPieDish>();

            Events.BuildGameDataEvent += delegate (object s, BuildGameDataEventArgs args)
            {
                ModRegistry.HandleBuildGameDataEvent(args);
            };
        }
        private static T1 GetModdedGDO<T1, T2>() where T1 : GameDataObject
        {
            return (T1)GDOUtils.GetCustomGameDataObject<T2>().GameDataObject;
        }
        private static T GetExistingGDO<T>(int id) where T : GameDataObject
        {
            return (T)GDOUtils.GetExistingGDO(id);
        }
        internal static T Find<T>(int id) where T : GameDataObject
        {
            return (T)GDOUtils.GetExistingGDO(id) ?? (T)GDOUtils.GetCustomGameDataObject(id)?.GameDataObject;
        }
    }
}
