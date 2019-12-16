using MechaMonsters.Items;
using MechaMonsters.Tiles;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using System.IO;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent.Generation;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Terraria.World.Generation;
using static Terraria.ModLoader.ModContent;

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

            tasks.Insert(shiniesIndex + 4, new PassLegacy("Generating Ancinet Tablets", GenAncientTablets));
        }

        private void GenAncientTablets(GenerationProgress progress)
        {
            progress.Message = "Generating Ancient Tablets";

            for (int k = 0; k < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 6E-05); k++)
            {
                int i2 = WorldGen.genRand.Next(0, Main.maxTilesX);
                int j2 = WorldGen.genRand.Next((int)(Main.maxTilesY * .3f), (int)(Main.maxTilesY * .45f));

                WorldGen.OreRunner(i2, j2, WorldGen.genRand.Next(3, 4), WorldGen.genRand.Next(3, 8), (ushort)mod.TileType("AncientTabletOre"));
            }
        }
    }
}