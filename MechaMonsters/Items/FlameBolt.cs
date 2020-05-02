using Terraria.ID;
using Terraria.ModLoader;

namespace MechaMonsters.Items
{
	public class FlameBolt : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Flare Bolt");
            Tooltip.SetDefault("For Ages 10+");
		}
		public override void SetDefaults()
		{
			item.damage = 35;
			item.magic = true;
			item.mana = 10;
			item.width = 100;
			item.height = 200;
			item.useTime = 25;
			item.useAnimation = 25;
			item.useStyle = 5;
			item.noMelee = true;
			item.channel = true;
			item.shootSpeed = 6.5f;
			item.knockBack = 4;
			item.value = 140;
			item.rare = 3;
			item.shoot = mod.ProjectileType("FlameBolt");
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);

			recipe.AddIngredient(ItemID.Book, 1);
			recipe.AddIngredient(ItemID.HellstoneBar, 10);
			recipe.AddIngredient(mod.ItemType("AncientTablet"), 15);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}