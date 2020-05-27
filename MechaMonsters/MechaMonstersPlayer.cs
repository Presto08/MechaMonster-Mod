using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.Graphics.Shaders;
using Terraria.ModLoader;
using Terraria.ID;
//using Tremor.Items;
//using Tremor.NPCs;

namespace MechaMonsters
{
	public class MechaMonstersPlayer : ModPlayer
	{
		public bool testMinion;

		//public int LastChest;

		public override void UpdateDead()
		{
			
		}

		/*public override void PreUpdateBuffs()
		{
			if (Main.netMode != 1)
			{
				if (player.chest == -1 && LastChest >= 0 && Main.chest[LastChest] != null)
				{
					int x2 = Main.chest[LastChest].x;
					int y2 = Main.chest[LastChest].y;
					//ChestItemSummonCheck(x2, y2, mod);
				}
				LastChest = player.chest;
			}
		}*/
		public override void PostUpdateEquips()
		{
			
		}

		public override void ResetEffects()
		{
			testMinion = false;
		}

		public override void OnRespawn(Player player)
		{

		}

		
		public override void UpdateBiomes()
		{

		}

		public override void PostUpdate()
		{
			
		}

		public override void SetupStartInventory(IList<Item> items)
		{
			Item item = new Item();
			//item.SetDefaults(mod.ItemType("AdventurerSpark"));
			//item.stack = 1;
			//items.Add(item);
		}

		public override bool CustomBiomesMatch(Player other)
		{
			var modOther = other.GetModPlayer<MechaMonstersPlayer>();
			return false;
			//return ZoneTowerNova == modOther.ZoneTowerNova;
		}

		public override void CopyCustomBiomesTo(Player other)
		{
			var modOther = other.GetModPlayer<MechaMonstersPlayer>();
			//modOther.ZoneTowerNova = ZoneTowerNova;
		}

		public override void SendCustomBiomes(BinaryWriter writer)
		{
			/*byte flags = 0;
			if (ZoneGranite)
			{
				flags |= 1;
			}
			if (ZoneTowerNova)
			{

				flags |= 2;
			}
			writer.Write(flags);*/
		}

		public override void ReceiveCustomBiomes(BinaryReader reader)
		{
			/*byte flags = reader.ReadByte();
			ZoneGranite = ((flags & 1) == 1);
			ZoneTowerNova = ((flags & 2) == 2);*/
		}

		public void OnHit(float x, float y, Entity victim)
		{

		}

		public override void UpdateBadLifeRegen()
		{
			
		}

		private void ResetRegen(bool condition, Player player)
		{
			if (condition)
			{
				if (player.lifeRegen > 0)
				{
					player.lifeRegen = 0;
				}
				player.lifeRegenTime = 0;
			}
		}

		public override void UpdateBiomeVisuals()
		{
			/*TremorPlayer modPlayer = Main.player[Main.myPlayer].GetModPlayer<TremorPlayer>(mod);
			bool UseEffects = modPlayer.ZoneIce;
			player.ManageSpecialBiomeVisuals("Tremor:Ice", UseEffects);
			//player.ManageSpecialBiomeVisuals("Blizzard", UseEffects);
			player.ManageSpecialBiomeVisuals("Tremor:CogLord", NPC.AnyNPCs(mod.NPCType("CogLord")));
			bool useNova = ZoneTowerNova || NovaMonolith;
			player.ManageSpecialBiomeVisuals("Tremor:Nova", useNova);*/
		}

		public override void CatchFish(Item fishingRod, Item bait, int power, int liquidType, int poolSize, int worldLayer, int questFish, ref int caughtType, ref bool junk)
		{

		}
	}
}