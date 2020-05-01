using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

//Creates and manages recipes
public sealed class RecipeUtils
{
    //Creates recipes
	public static void QuickRecipe(Mod mod, short resultType, int[,] ingredients, short? reqTileType = null)
    {
        ModRecipe recipe = new ModRecipe(mod);
        recipe.SetResult(resultType);
        for (int i = 0; i < ingredients.GetUpperBound(0); i++)
        {
            recipe.AddIngredient(ingredients[i, 0], ingredients[i, 1]);
        }
        if (reqTileType != null)
            recipe.AddTile(reqTileType.Value);

        recipe.AddRecipe();
    }

    //Deletes existing recipes
    public static void RemoveRecipe(Mod mod, int result, int ingredient)
    {
        var rf = new RecipeFinder();
        rf.SetResult(result);
        rf.AddIngredient(ingredient);

        var found = rf.SearchRecipes();

        found.ForEach(recipe =>
        {
            var rEditor = new RecipeEditor(recipe);
            rEditor.DeleteRecipe();
        });
    }
}
