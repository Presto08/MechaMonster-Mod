using MechaMonsters.Items;
using MechaMonsters.Tiles;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Terraria;
using Terraria.DataStructures;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.GameContent.Generation;
using Terraria.ModLoader.IO;
using Terraria.World.Generation;
using System.Threading;

namespace MechaMonsters
{
	class MechaMonstersWorld : ModWorld
	{
		public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight)
		{
			int shiniesIndex = tasks.FindIndex(genpass => genpass.Name.Equals("Shinies"));
			if (shiniesIndex == -1)
			{
				return;
			}

			tasks.Insert(shiniesIndex + 1, new PassLegacy("Generating Ancinet Tablets", GenAncientTablets));
			tasks.Insert(90, new PassLegacy("Generating Test Biome", GenTestBiome));
		}

		public override void ModifyHardmodeTasks(List<GenPass> list)
		{
			int index = list.FindIndex(genpass => genpass.Name.Equals("Hardmode Announcement"));

			//list.Insert(2, new PassLegacy("Generating Ancient Tablets", GenAncientTabletsHardmode));
		}

		private void GenAncientTablets(GenerationProgress progress)
		{
			progress.Message = "Generating Ancient Tablets";
			ulong count = 0;
			while (count < 1)
			{
				for (int k = 0; k < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 6E-05); k++)
				{
					int i2 = WorldGen.genRand.Next(0, Main.maxTilesX);
					int j2 = WorldGen.genRand.Next((int)(Main.maxTilesY * .3f), (int)(Main.maxTilesY * .6f));

					WorldGen.TileRunner(i2, j2, WorldGen.genRand.Next(3, 6), WorldGen.genRand.Next(3, 8), (ushort)mod.TileType("AncientTabletOre"), false, 0f, 0f, false, true);
					count++;
				}
			}
		}

		private void GenAncientTabletsHardmode(GenerationProgress progress)
		{
			//progress.Message = "Generating Ancient Tablets";
			ulong count = 0;
			while (count < 1)
			{
				for (int k = 0; k < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 6E-05); k++)
				{
					int i2 = WorldGen.genRand.Next(0, Main.maxTilesX);
					int j2 = WorldGen.genRand.Next((int)(Main.maxTilesY * .3f), (int)(Main.maxTilesY * .6f));

					WorldGen.TileRunner(i2, j2, WorldGen.genRand.Next(3, 6), WorldGen.genRand.Next(3, 8), (ushort)mod.TileType("AncientTabletOre"), false, 0f, 0f, false, true);
					count++;
				}
			}

			NetMessage.BroadcastChatMessage(NetworkText.FromKey("Ancient tablets have been discovered underground", new object[0]), new Color(77, 11, 65), -1);
		}

		private void GenTestBiome(GenerationProgress progress)
		{
			progress.Message = "Generating Test Biome";
			RETRY:

			int size = 0;
			// unused?
			//int[] BlockNums = { 23, 25, 147, 161, 163, 164, 200, 0, 2 };
			//int[] OreNums = { 6, 7, 8, 9, 221, 222, 223, 204, 166, 167, 168, 169, 107, 108, 111, 22 };
			if (Main.maxTilesX == 4200 && Main.maxTilesY == 1200)
			{
				size = 105;
			}
			else if (Main.maxTilesX == 6300 && Main.maxTilesY == 1800)
			{
				size = 198;
			}
			else if (Main.maxTilesX == 8400 && Main.maxTilesY == 2400)
			{
				size = 270;
			}

			int xRange = 0;

			if (size == 105)
			{
				xRange = 100;
			}
			else if (size == 198)
			{
				xRange = 200;
			}
			else if (size == 270)
			{
				xRange = 300;
			}

			int startPositionX = new Random().Next(0 + xRange, Main.maxTilesX - 2 - xRange);
			int startPositionY = (int)Main.worldSurface;
			var startX = startPositionX;
			var startY = startPositionY;

			

			var tile = Main.tile[startPositionX, startPositionY].type;
			if (tile == 0 || tile == 2 || tile == TileID.Stone)
			{
				for (int x = startPositionX - 40; x <= startPositionX + 40; x++)
                {
					int y = startPositionY - 30;
					if (Main.tile[x, y].type == 23 || Main.tile[x, y].type == 25 || Main.tile[x, y].type == 53 || Main.tile[x, y].type == 199 || Main.tile[x, y].type == 203)
                    {
						goto RETRY;
                    }
                }

				int sizeX = size / 2;

				for (int y = startY + size; y >= startY - size; y--)
				{
					if (WorldGen.genRand.Next(0, 7) < 4) sizeX++;
					for (int x = startX - sizeX; x <= startX + sizeX; x++)
					{
						if (Vector2.Distance(new Vector2(startX, startY), new Vector2(x, y)) <= size)
						{
							/*if (Main.tile[x, y].wall == 40 || Main.tile[x, y].wall == 71)	//Replace wall tiles
							{
								Main.tile[x, y].wall = (ushort)mod.WallType("IceWall");
							}*/
							if (Main.tile[x, y].type == 2)
                            {
								Main.tile[x, y].type = (ushort)mod.TileType("TestGrass");
                            }
							else if (Main.tile[x, y].type == 1 || Main.tile[x, y].type == 0)
							{
								Main.tile[x, y].type = (ushort)mod.TileType("TestStone");
							}
							else if (Main.tile[x, y].type == 6 || Main.tile[x, y].type == 7 || Main.tile[x, y].type == 8 || Main.tile[x, y].type == 9 || Main.tile[x, y].type == 221 || Main.tile[x, y].type == 222 || Main.tile[x, y].type == 223 || Main.tile[x, y].type == 204 || Main.tile[x, y].type == 166 || Main.tile[x, y].type == 167 || Main.tile[x, y].type == 168 || Main.tile[x, y].type == 169 || Main.tile[x, y].type == 221 || Main.tile[x, y].type == 107 || Main.tile[x, y].type == 108 || Main.tile[x, y].type == 22 || Main.tile[x, y].type == 111 || Main.tile[x, y].type == 123 || Main.tile[x, y].type == 224 || Main.tile[x, y].type == 40)
							{
								Main.tile[x, y].type = 7;
							}
						}
					}
				}
			}
			else
				goto RETRY;
		}
	}
}