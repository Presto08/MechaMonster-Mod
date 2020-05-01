using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MechaMonsters.Tiles
{
	public class AncientTabletOre : ModTile
	{
		public override void SetDefaults()
		{
		    //TileID.Sets.Ore[Type] = true;
			Main.tileSpelunker[Type] = true; // The tile will be affected by spelunker highlighting
			Main.tileValue[Type] = 410; // Metal Detector value, see https://terraria.gamepedia.com/Metal_Detector
			Main.tileMergeDirt[Type] = true;
			Main.tileSolid[Type] = true;
			Main.tileBlockLight[Type] = true;

			ModTranslation name = CreateMapEntryName();
			name.SetDefault("Ancient Tablet Ore");
			AddMapEntry(new Color(77, 11, 65), name);

			dustType = 84;
			drop = ModContent.ItemType<Items.AncientTablet>();
			soundType = 21;
			soundStyle = 1;
			//mineResist = 4f;
			minPick = 40;
		}

        public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
        {
            r = 0.886f;
            g = 0f;
            b = 0.482f;
        }
    } 
}