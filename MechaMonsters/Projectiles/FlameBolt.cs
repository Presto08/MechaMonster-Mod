using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MechaMonsters.Projectiles
{
	public class FlameBolt : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("English Display Name Here");
		}

		public override void SetDefaults()
		{
			projectile.arrow = false;
			projectile.width = 10;
			projectile.height = 10;
			projectile.aiStyle = 8;
			projectile.friendly = true;
			projectile.ranged = true;
			projectile.maxPenetrate = 3;
			aiType = 16;
		}

		// Additional hooks/methods here.
	}
}