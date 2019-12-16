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
		    TileID.Sets.Ore[Type] = true;
			Main.tileSpelunker[Type] = true; // The tile will be affected by spelunker highlighting
			Main.tileValue[Type] = 410; // Metal Detector value, see https://terraria.gamepedia.com/Metal_Detector
			Main.tileShine2[Type] = true; // Modifies the draw color slightly.
			Main.tileShine[Type] = 219; // How often tiny dust appear off this tile. Larger is less frequently
			Main.tileMergeDirt[Type] = true;
			Main.tileSolid[Type] = true;
			Main.tileBlockLight[Type] = true;

			ModTranslation name = CreateMapEntryName();
			name.SetDefault("Ancient Tablet Ore");
			AddMapEntry(new Color(226, 0, 123), name);

			dustType = 84;
			drop = ModContent.ItemType<Items.Placeable.AncientTabletOre>();
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