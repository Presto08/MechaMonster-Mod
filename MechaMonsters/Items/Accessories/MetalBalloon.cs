using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace MechaMonsters.Items.Accessories
{
	public class MetalBalloon : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Metal Balloon");
			Tooltip.SetDefault("Perfect Birthday Present For All Ages!");
		}
		public override void SetDefaults()
		{
			item.width = 25;
			item.height = 50;
			item.value = 10000;
			item.rare = 2;
            item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool showVisual)
		{
			player.noFallDmg = true;
			player.jumpBoost = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SilverBar, 10);
			recipe.AddIngredient(ItemID.WhiteString, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();

			ModRecipe recipe2 = new ModRecipe(mod);
			recipe2.AddIngredient(ItemID.TungstenBar, 10);
			recipe2.AddIngredient(ItemID.WhiteString, 1);
			recipe2.AddTile(TileID.Anvils);
			recipe2.SetResult(this);
			recipe2.AddRecipe();
		}
}
}