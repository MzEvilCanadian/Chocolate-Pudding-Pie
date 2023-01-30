using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using System.Collections.Generic;
using UnityEngine;

namespace ChocolatePuddingPie.Customs
{
    class ChocolatePuddingPieServing : CustomItem
    {
        public override string UniqueNameID => "Chocolate Pudding Pie Serving";
        public override GameObject Prefab => Main.bundle.LoadAsset<GameObject>("ChocolatePuddingPieServing");
        public override ItemCategory ItemCategory => ItemCategory.Generic;
        public override ItemStorage ItemStorageFlags => ItemStorage.StackableFood;
        public override ItemValue ItemValue => ItemValue.Small;

        
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

            materials[0] = MaterialUtils.GetExistingMaterial("Egg - White");
            MaterialUtils.ApplyMaterial(Prefab, "Topping", materials);
          }
        
    }
}
