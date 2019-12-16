using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace MechaMonsters.Items.Accessories
{
	public class BionicFist : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bionic Lens");
			Tooltip.SetDefault("Bionic advancement from a time-travelling zombie. Increases attack damage for a price...");
		}
		public override void SetDefaults()
		{
			item.width = 25;
			item.height = 50;
			item.value = 100;
			item.rare = 3000;
            item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
            player.statLifeMax2 -= 20;
            player.meleeDamage += 0.25f;
		}
	}
}