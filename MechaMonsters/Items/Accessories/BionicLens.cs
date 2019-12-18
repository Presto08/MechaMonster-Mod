using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace MechaMonsters.Items.Accessories
{
	public class BionicLens : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bionic Lens");
			Tooltip.SetDefault("Bionic advancement from a time-travelling zombie. Increases defense for a price...");
		}
		public override void SetDefaults()
		{
			item.width = 25;
			item.height = 50;
			item.value = 100;
			item.rare = 3;
            item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
            player.statLifeMax2 -= 20;
            player.statDefense += 20;
		}
	}
}