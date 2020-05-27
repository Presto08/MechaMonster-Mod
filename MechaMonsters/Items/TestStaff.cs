using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MechaMonsters.Items
{
	public class TestStaff : ModItem
	{
		public override void SetDefaults()
		{
			//item.summon = true;
			item.mana = 1;
			item.width = 34;
			item.height = 28;

			item.useTime = 25;
			item.useAnimation = 25;
			item.useStyle = 1;
			item.noMelee = true;
			item.knockBack = 0;
			item.value = 8000;
			item.rare = 2;
			item.UseSound = SoundID.Item44;
			item.shoot = mod.ProjectileType("TestMinion");
			item.shootSpeed = 1f;
			item.buffType = mod.BuffType("TestMinionBuff");
			item.buffTime = 18000;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Test Staff");
			Tooltip.SetDefault("Summons a test minion to help out.\nGives speed at the constant cost of mana.");
		}

		public override bool AltFunctionUse(Player player)
		{
			return true;
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			return player.altFunctionUse != 2;
		}

		public override bool UseItem(Player player)
		{
			MechaMonstersPlayer modPlayer = (MechaMonstersPlayer)player.GetModPlayer(mod, "MechaMonstersPlayer");
			//modPlayer.testMinion = true;
			if (player.statManaMax < 20 || player.statManaMax2 < 20) return false;
			if (player.altFunctionUse == 2)
			{
				player.MinionNPCTargetAim();
			}
			return base.UseItem(player);
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wood, 8);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}