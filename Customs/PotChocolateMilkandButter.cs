﻿using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using System.Collections.Generic;
using UnityEngine;

namespace ChocolatePuddingPie.Customs
{
    class PotChocolateMilkandButter : CustomItemGroup
    {
        public override string UniqueNameID => "Pot Chocolate and Milk";
        public override GameObject Prefab => Mod.Pot.Prefab;         // Filler line until graphics are made
        public override ItemCategory ItemCategory => ItemCategory.Generic;
        public override ItemStorage ItemStorageFlags => ItemStorage.Dish;

        public override List<ItemGroup.ItemSet> Sets => new List<ItemGroup.ItemSet>()
        {
            new ItemGroup.ItemSet()
            {
                Max = 1,
                Min = 1,
                Items = new List<Item>()
                {
                    Mod.PotChocolateandMilk
                }
            },
            new ItemGroup.ItemSet()
            {
                Max = 1,
                Min = 1,
                Items = new List<Item>()
                {
                    Mod.ButterSlice
                }
            },
        };
        public override List<Item.ItemProcess> Processes => new List<Item.ItemProcess>
        {
            new Item.ItemProcess
            {
                Duration = 10,
                Process = Mod.Cook,
                Result = Mod.CookedFillingPot
            }
        };

        /*   public override void OnRegister(GameDataObject gameDataObject)
           {
               var materials = new Material[]
               {
                   MaterialUtils.GetExistingMaterial("Bread - Inside"),
                };
               MaterialUtils.ApplyMaterial(Prefab, "GameObject", materials);
               materials[0] = MaterialUtils.GetExistingMaterial("Bread");
               MaterialUtils.ApplyMaterial(Prefab, "GameObject (1)", materials);
               materials[0] = MaterialUtils.GetExistingMaterial("Paper - Postit Yellow");
               MaterialUtils.ApplyMaterial(Prefab, "GameObject (2)", materials);

               // MaterialUtils.ApplyMaterial([object], [name], [material list]
           }
        */
    }
}