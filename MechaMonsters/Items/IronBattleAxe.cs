using Terraria.ID;
using Terraria.ModLoader;

namespace MechaMonsters.Items
{
	public class IronBattleAxe : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Iron Battle Axe");
            Tooltip.SetDefault("Yes it can kill mobs, no it can't chop trees.");
		}
		public override void SetDefaults()
		{
			item.damage = 40;
			item.melee = true;
			item.width = 25;
			item.height = 50;
			item.useTime = 55;
            item.useAnimation = 30;
			item.useStyle = 1;
			item.knockBack = 20;
			item.value = 252525;
			item.rare = 5;
			item.UseSound = SoundID.Item1;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.IronBar, 12); 
            recipe.AddIngredient(ItemID.Wood, 12);

            recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}