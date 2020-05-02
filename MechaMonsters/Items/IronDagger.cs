using Terraria.ID;
using Terraria.ModLoader;

namespace MechaMonsters.Items
{
	public class IronDagger : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Iron Dagger");
            Tooltip.SetDefault("-Light Melee Class-");
		}
		public override void SetDefaults()
		{
			item.damage = 10;
			item.melee = true;
			item.width = 50;
			item.height = 100;
			item.useTime = 12;
			item.useAnimation = 12;
			item.useStyle = 3;
			item.knockBack = 2;
			item.value = 140;
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Wood, 6);
            recipe.AddIngredient(ItemID.IronBar, 5);
			recipe.AddIngredient(ItemID.Gel, 30);
			recipe.AddIngredient(ItemID.BottledHoney, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}