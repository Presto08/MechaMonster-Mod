using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace MechaMonsters.Items.Accessories
{
	public class BionicBoots : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bionic Boots");
			Tooltip.SetDefault("Bionic advancement from a time-travelling zombie. Can fall from any height and run faster for a price...");
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
            player.statLifeMax2 -= (int) (player.statLifeMax * 0.2f);
            player.moveSpeed += 0.6f;
            player.noFallDmg = true;
            player.jumpBoost = true;
		}
	}
}