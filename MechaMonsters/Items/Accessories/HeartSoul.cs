using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace MechaMonsters.Items.Accessories
{
	public class HeartSoul : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Soul-Heart Container");
			Tooltip.SetDefault("A strange Heart amalgamation that adds and regenerates life...");
		}
		public override void SetDefaults()
		{
			item.width = 25;
			item.height = 50;
			item.value = 10000;
			item.rare = 3;
            item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool showVisual)
		{
            player.statLifeMax2 += 100;
            player.lifeRegen += 2;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SoulofFlight, 10);
			recipe.AddIngredient(ItemID.SoulofLight, 10);
			recipe.AddIngredient(ItemID.SoulofNight, 10);
			recipe.AddIngredient(ItemID.SoulofFright, 10);
			recipe.AddIngredient(ItemID.SoulofSight, 10);
			recipe.AddIngredient(ItemID.SoulofMight, 10);
			recipe.AddIngredient(ItemID.HallowedBar, 20);
			recipe.AddIngredient(ItemID.LifeCrystal, 5);
			recipe.AddTile(134);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}