using Terraria.ID;
using Terraria.ModLoader;

namespace MechaMonsters.Items
{
	public class StoneSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Stone Sword");
			Tooltip.SetDefault("When wood is too weak.");
		}
		public override void SetDefaults()
		{
            item.damage = 15;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 50;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.StoneBlock, 45);
                recipe.AddIngredient(ItemID.Wood, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}