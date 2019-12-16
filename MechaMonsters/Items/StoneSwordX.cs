using Terraria.ID;
using Terraria.ModLoader;

namespace MechaMonsters.Items
{
	public class StoneSwordX : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Stone Sword X");
			Tooltip.SetDefault("When wood and stone is too weak.");
		}
		public override void SetDefaults()
		{
            item.damage = 45;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 45;
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
                recipe.AddIngredient(ItemID.HellstoneBrick, 15);
                recipe.AddIngredient(ItemID.StoneBlock, 99);
                recipe.AddIngredient(ItemID.Obsidian, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}