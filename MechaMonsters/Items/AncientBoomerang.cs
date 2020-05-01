using Terraria.ID;
using Terraria.ModLoader;
using MechaMonsters.RecipeUtils;

namespace MechaMonsters.Items
{
	public class AncientBoomerang : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ancient Boomerang");
            Tooltip.SetDefault("-Thrower Class-");
		}
		public override void SetDefaults()
		{
			item.damage = 25;
			item.ranged = true;
			item.width = 50;
			item.height = 100;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 3;
			item.shootSpeed = 5.5f;
			item.knockBack = 2;
			item.value = 140;
			item.rare = 1;
			item.shoot = mod.ProjectileType("AncientBoomerang");
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
		}

		public override void AddRecipes()
		{
			int[,] ingredients = new int[,]
			{
				{ItemID.Wood, 6},
				{ItemID.IronBar, 5},
				{ItemID.Gel, 30},
				{ItemID.BottledHoney, 1 }
			};

			RecipeUtils.QuickRecipe(mod, this, ingredients, TileID.Anvils);
		}
	}
}