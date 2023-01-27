using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using System.Collections.Generic;
using UnityEngine;

namespace ChocolatePuddingPie.Customs
{
    class PotandChocolate : CustomItemGroup
    {
        public override string UniqueNameID => "Pot and Chocolate";
        public override GameObject Prefab => Mod.Onion.Prefab;         // Filler line until graphics are made
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
                    Mod.Pot
                }
            },
            new ItemGroup.ItemSet()
            {
                Max = 1,
                Min = 1,
                Items = new List<Item>()
                {
                    Mod.ChoppedChocolate
                }
            },
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
