using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using System.Collections.Generic;
using UnityEngine;

namespace ChocolatePuddingPie.Customs
{
    class ChocolatePuddingPieServing : CustomItem
    {
        public override string UniqueNameID => "ChocolatePuddingPieServing";
        public override GameObject Prefab => Mod.Onion.Prefab;         // Filler line until graphics are made
        public override ItemCategory ItemCategory => ItemCategory.Generic;
        public override ItemStorage ItemStorageFlags => ItemStorage.StackableFood;
        public override ItemValue ItemValue => ItemValue.Small;

        /*
         * public override void OnRegister(GameDataObject gameDataObject)
          {

              var materials = new Material[]
              {
                  MaterialUtils.GetExistingMaterial("Bread - Inside Cooked"),
               };
               MaterialUtils.ApplyMaterial(Prefab, "GameObject", materials);
              materials[0] = MaterialUtils.GetExistingMaterial("Bread - Cooked");
              MaterialUtils.ApplyMaterial(Prefab, "GameObject (1)", materials);
              materials[0] = MaterialUtils.GetExistingMaterial("Plastic - Yellow");
              MaterialUtils.ApplyMaterial(Prefab, "GameObject (2)", materials);
              materials[0] = MaterialUtils.GetExistingMaterial("Plastic - Dark Green");
              MaterialUtils.ApplyMaterial(Prefab, "GameObject (3)", materials);
            
        // MaterialUtils.ApplyMaterial([object], [name], [material list]
         }
        */
    }
}
