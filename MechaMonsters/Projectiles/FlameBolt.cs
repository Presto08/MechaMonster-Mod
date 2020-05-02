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
			Projectiles.maxPenetrate = 3;
			aiType = 27;
		}

		// Additional hooks/methods here.
	}
}