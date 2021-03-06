using Terraria.ID;
using Terraria.ModLoader;

namespace MechaMonsters.Items
{
	public class AncientTablet : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ancient Tablet");
			Tooltip.SetDefault("It says something on it, but you can't read it.");
		}
		public override void SetDefaults()
		{
            item.width = 25;
            item.height = 50;
            item.value = 252525;
            item.rare = 5;
            item.maxStack = 99;
        }
	}
}