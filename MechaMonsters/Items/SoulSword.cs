using Terraria.ID;
using Terraria.ModLoader;

namespace MechaMonsters.Items
{
	public class SoulSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Soul-Infused Sword");
			Tooltip.SetDefault("Those from the dead come back in the shape of a sword.");
		}
		public override void SetDefaults()
		{
			item.damage = 45;
			item.melee = true;
			item.width = 25;
			item.height = 50;
			item.useTime = 40;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 1;
			item.value = 25250;
			item.rare = 5;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
            item.shoot = mod.ProjectileType("Blast");
            item.shootSpeed = 8f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.HellstoneBar, 25);
            recipe.AddIngredient(ItemID.Bone, 99);
            recipe.AddIngredient(ItemID.CopperPickaxe, 1);
            recipe.AddIngredient(ItemID.CopperAxe, 1);
            recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}