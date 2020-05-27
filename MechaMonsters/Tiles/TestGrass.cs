using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MechaMonsters.Tiles
{
	public class TestGrass : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileSpelunker[Type] = false;
			Main.tileMergeDirt[Type] = true;
			Main.tileSolid[Type] = true;
			Main.tileBlockLight[Type] = true;

			AddMapEntry(new Color(11, 68, 61));

			dustType = 1;
			drop = ItemID.DirtBlock;
			soundType = 21;
			soundStyle = 1;
			minPick = 35;
		}

        /*public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
        {
            r = 17f / 255f;
            g = 102f / 255f;
            b = 90f / 255f;
        }*/
    } 
}