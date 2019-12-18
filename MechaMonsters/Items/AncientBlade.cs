using Terraria.ID;
using Terraria.ModLoader;

namespace MechaMonsters.Items
{
	public class AncientBlade : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ancient Blade");
			Tooltip.SetDefault("You know, just stick a tablet in everything. It's ought to work!")
		}
		public override void SetDefaults()
		{
			item.damage = 30;
			item.melee = true;
			item.width = 25;
			item.height = 50;
			item.useTime = 25;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 10;
			item.value = 252525;
			item.rare = 5;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(Mod.ItemID.AncientTablet, 2);
            recipe.AddIngredient(ItemID.IronBar, 5);
            recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}