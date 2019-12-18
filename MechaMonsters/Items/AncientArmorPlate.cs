using Terraria.ID;
using Terraria.ModLoader;

namespace MechaMonsters.Items
{
	public class AncientArmorPlate : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ancient Armor Plate");
            Tooltip.SetDefault("A component for making basic Mecha Armor.");
		}
        public override void SetDefaults()
        {
            item.width = 25;
            item.height = 50;
            item.value = 252525;
            item.rare = 5;
            item.maxStack = 99;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(Mod.ItemType("AncientTablet"), 2);
            recipe.AddIngredient(ItemID.IronBar, 5);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }
}
