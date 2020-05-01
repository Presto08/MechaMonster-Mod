using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MechaMonsters.Projectiles
{
	public class AncientBoomerang : ModProjectile
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
			projectile.aiStyle = 3;
			projectile.friendly = true;
			projectile.ranged = true;
			aiType = ProjectileID.EnchantedBoomerang;
		}

		// Additional hooks/methods here.
	}
}