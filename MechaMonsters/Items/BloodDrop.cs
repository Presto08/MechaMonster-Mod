using Terraria.ID;
using Terraria.ModLoader;

namespace MechaMonsters.Items
{
	public class BloodDrop : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bloody Droplet");
			Tooltip.SetDefault("It smells like many metals.");
		}
		public override void SetDefaults()
		{
            item.width = 10;
            item.height = 20;
            item.value = 252525;
            item.rare = 5;
            item.maxStack = 999;
        }
	}
}