using Terraria;
using Terraria.ModLoader;

namespace MechaMonsters.Buffs
{
	public class TestMinionBuff : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Test Minion");
			Description.SetDefault("The test minion is here to help");
			Main.buffNoTimeDisplay[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			MechaMonstersPlayer modPlayer = (MechaMonstersPlayer)player.GetModPlayer(mod, "MechaMonstersPlayer");
			if (player.ownedProjectileCounts[mod.ProjectileType("TestMinion")] > 0)
			{
				modPlayer.testMinion = true;
			}
			if (!modPlayer.testMinion)
			{
				player.DelBuff(buffIndex);
				buffIndex--;
			}
			else
			{
				player.buffTime[buffIndex] = 18000;
			}

			player.statLifeMax2 += 100;
			player.statManaMax2 -= 20;
		}
	}
}