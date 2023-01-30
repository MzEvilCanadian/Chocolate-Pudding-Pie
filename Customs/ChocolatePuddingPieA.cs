using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using System.Collections.Generic;
using UnityEngine;

namespace ChocolatePuddingPie.Customs
{
    class ChocolatePuddingPieA : CustomItemGroup
    {
        public override string UniqueNameID => "ChocolatePuddingPieA";
        public override GameObject Prefab => Main.bundle.LoadAsset<GameObject>("ChocolatePuddingPieA");
        public override ItemCategory ItemCategory => ItemCategory.Generic;
        public override ItemStorage ItemStorageFlags => ItemStorage.StackableFood;
        public override List<ItemGroup.ItemSet> Sets => new List<ItemGroup.ItemSet>()
        {
            new ItemGroup.ItemSet()
            {
                Max = 1,
                Min = 1,
                Items = new List<Item>()
                {
                    Main.ChocolateFilling
                }
            },
            new ItemGroup.ItemSet()
            {
                Max = 1,
                Min = 1,
                Items = new List<Item>()
                {
                    Main.PieCrust
                }
            },
        };
        public override List<Item.ItemProcess> Processes => new List<Item.ItemProcess>
        {
            new Item.ItemProcess
            {
                Duration = 1,
                Process = Main.Knead,
                Result = Main.ChocolatePuddingPieServing
            }
        };

          public override void OnRegister(GameDataObject gameDataObject)
          {
              var materials = new Material[]
              {
                  MaterialUtils.GetExistingMaterial("Bread - Inside Cooked"),
              };
            MaterialUtils.ApplyMaterial(Prefab, "Crust/Slice 1", materials);
            MaterialUtils.ApplyMaterial(Prefab, "Crust/Slice 2", materials);
            MaterialUtils.ApplyMaterial(Prefab, "Crust/Slice 3", materials);
            MaterialUtils.ApplyMaterial(Prefab, "Crust/Slice 4", materials);

            materials[0] = MaterialUtils.GetExistingMaterial("Chocolate");
            MaterialUtils.ApplyMaterial(Prefab, "Filling/Slice 1", materials);
            MaterialUtils.ApplyMaterial(Prefab, "Filling/Slice 2", materials);
            MaterialUtils.ApplyMaterial(Prefab, "Filling/Slice 3", materials);
            MaterialUtils.ApplyMaterial(Prefab, "Filling/Slice 4", materials);
        }
        
    }
}
