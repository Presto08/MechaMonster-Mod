using Terraria.ID;
using Terraria.ModLoader;

namespace MechaMonsters.Items
{
	public class HeavyTabletHammer : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ancient Tablet Hammer");
            Tooltip.SetDefault("-Heavy Melee Class-");
		}
		public override void SetDefaults()
		{
			item.damage = 50;
			item.melee = true;
			item.width = 50;
			item.height = 100;
			item.useTime = 45;
			item.useAnimation = 45;
			item.useStyle = 1;
			item.knockBack = 8;
			item.value = 1400;
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.MeteoriteBar, 10);
			recipe.AddIngredient(mod.ItemType("AncientTabletBar"), 5);
			recipe.AddIngredient(mod.ItemType("HeavyIronHammer"), 1);
			recipe.AddTile(26);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}