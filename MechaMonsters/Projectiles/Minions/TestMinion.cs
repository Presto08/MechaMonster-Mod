using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;

namespace MechaMonsters.Projectiles.Minions
{
	public class TestMinion : Minion
	{
		public override void SetDefaults()
		{
			projectile.netImportant = true;
			projectile.CloneDefaults(199);
			aiType = 199;

			projectile.width = 50;
			projectile.height = 50;
			Main.projFrames[projectile.type] = 1;
			projectile.friendly = true;
			projectile.minion = true;
			projectile.minionSlots = 1;
			projectile.penetrate = -1;
			projectile.timeLeft = 18000;
			projectile.ignoreWater = true;
			projectile.tileCollide = false;
			ProjectileID.Sets.MinionTargettingFeature[projectile.type] = false;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("TestMinion");

		}

		public override bool OnTileCollide(Vector2 oldVelocity)
		{
			if (projectile.velocity.X != oldVelocity.X)
			{
				projectile.velocity.X = oldVelocity.X;
			}
			if (projectile.velocity.Y != oldVelocity.Y)
			{
				projectile.velocity.Y = oldVelocity.Y;
			}
			return false;
		}

		public override void CheckActive()
		{
			Player player = Main.player[projectile.owner];
			MechaMonstersPlayer modPlayer = (MechaMonstersPlayer)player.GetModPlayer(mod, "MechaMonstersPlayer");
			if (player.dead)
			{
				modPlayer.testMinion = false;
			}
			if (modPlayer.testMinion)
			{
				projectile.timeLeft = 2;
			}
		}

	}
}