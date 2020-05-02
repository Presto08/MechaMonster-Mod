using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

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
			item.thrown = true;
			item.noMelee = true;
			item.channel = true;
			item.width = 50;
			item.height = 100;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 3;
			item.shootSpeed = 8.5f;
			item.knockBack = 4;
			item.value = 140;
			item.rare = 3;
			item.shoot = mod.ProjectileType("AncientBoomerang");
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
		}

		public override bool CanUseItem(Player player)	//Restricts throwing to one boomerang at a time
		{
			for (int i = 0; i < 1000; ++i)
			{
				if (Main.projectile[i].active && Main.projectile[i].owner == Main.myPlayer && Main.projectile[i].type == item.shoot)
				{
					return false;
				}
			}
			return true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);

			recipe.AddIngredient(ItemID.MeteoriteBar, 15);
			recipe.AddIngredient(mod.ItemType("AncientTablet"), 3);
			recipe.AddIngredient(mod.ItemType("AncientTabletBar"), 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}