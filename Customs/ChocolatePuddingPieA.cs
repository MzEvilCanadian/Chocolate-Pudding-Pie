using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using System.Collections.Generic;
using UnityEngine;

namespace ChocolatePuddingPie.Customs
{
    class ChocolatePuddingPieA : CustomItemGroup
    {
        public override string UniqueNameID => "ChocolatePuddingPie";
        public override GameObject Prefab => Mod.Flour.Prefab;
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
                    Mod.ChocolateFillingPortion
                }
            },
            new ItemGroup.ItemSet()
            {
                Max = 1,
                Min = 1,
                Items = new List<Item>()
                {
                    Mod.PieCrust
                }
            },
        };
        public override List<Item.ItemProcess> Processes => new List<Item.ItemProcess>
        {
            new Item.ItemProcess
            {
                Duration = 1,
                Process = Mod.Knead,
                Result = Mod.ChocolatePuddingPieServing
            }
        };

        /*  public override void OnRegister(GameDataObject gameDataObject)
          {
              var materials = new Material[]
              {
                  MaterialUtils.GetExistingMaterial("Bread - Inside"),
              };
              MaterialUtils.ApplyMaterial(Prefab, "GameObject", materials);
              materials[0] = MaterialUtils.GetExistingMaterial("Bread - Cooked");
              MaterialUtils.ApplyMaterial(Prefab, "GameObject (1)", materials);
              materials[0] = MaterialUtils.GetExistingMaterial("Olive Oil Bottle");
              MaterialUtils.ApplyMaterial(Prefab, "GameObject (3)", materials);

              // MaterialUtils.ApplyMaterial([object], [name], [material list]
          }
        */
    }
}
