using Terraria.ID;
using Terraria.ModLoader;

namespace MechaMonsters.Items
{
	public class AncientTabletBar : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ancient Tablet Bar");
			Tooltip.SetDefault("Gluten Free!");
		}
		public override void SetDefaults()
		{
            item.width = 25;
            item.height = 50;
            item.value = 252525;
            item.rare = 2;
            item.maxStack = 999;
        }
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CrimtaneBar, 5);
			recipe.AddIngredient(ItemID.MeteoriteBar, 5);
			recipe.AddIngredient(mod.ItemType("AncientTablet"), 10);
			recipe.AddTile(77);
			recipe.SetResult(this);
			recipe.AddRecipe();

			ModRecipe recipe2 = new ModRecipe(mod);
			recipe2.AddIngredient(ItemID.DemoniteBar, 5);
			recipe2.AddIngredient(ItemID.MeteoriteBar, 5);
			recipe2.AddIngredient(mod.ItemType("AncientTablet"), 10);
			recipe2.AddTile(77);
			recipe2.SetResult(this);
			recipe2.AddRecipe();
		}
	}
}