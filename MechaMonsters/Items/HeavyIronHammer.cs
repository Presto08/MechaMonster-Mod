using Terraria.ID;
using Terraria.ModLoader;

namespace MechaMonsters.Items
{
	public class HeavyIronHammer : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Heavy Iron Hammer");
            Tooltip.SetDefault("-Heavy Melee Class-");
		}
		public override void SetDefaults()
		{
			item.damage = 30;
			item.melee = true;
			item.width = 50;
			item.height = 100;
			item.useTime = 40;
			item.useAnimation = 40;
			item.useStyle = 1;
			item.knockBack = 8;
			item.value = 140;
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Wood, 6);
            recipe.AddIngredient(ItemID.IronBar, 10);
			recipe.AddIngredient(ItemID.Gel, 30);
			recipe.AddIngredient(ItemID.BottledHoney, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}