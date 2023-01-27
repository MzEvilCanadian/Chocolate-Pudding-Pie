using KitchenData;
using System.Collections.Generic;

namespace ChocolatePuddingPie.Registry
{
    public interface ILocalisedRecipeHolder
    {
        IDictionary<Locale, string> LocalisedRecipe { get; }

    }
}
