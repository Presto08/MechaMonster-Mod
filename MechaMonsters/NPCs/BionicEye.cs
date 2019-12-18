using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace MechaMonsters.NPCs
{
    public class BionicEye : ModNPC // ModNPC is used for Custom NPCs
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bionic Eye");
        }

        public override void SetDefaults()
        {
            npc.width = 18;
            npc.height = 24;
            npc.damage = 12;
            npc.defense = 10;
            npc.lifeMax = 50;
            npc.HitSound = SoundID.NPCHit4;
            npc.DeathSound = SoundID.NPCDeath14;
            npc.value = 150f;
            npc.knockBackResist = 0.25f;
            npc.aiStyle = 2;
            Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.DemonEye]; //Main.npcFrameCount[2];
            aiType = NPCID.DemonEye; // aiType = 2;
            animationType = NPCID.DemonEye; // animationType = 2;aa
        }

        public override void NPCLoot()
        {
            if (Main.rand.Next(20) == 0)
            { 
                Item.NewItem(npc.getRect(), ItemID.IronBar, 2);
            }
            else if (Main.rand.Next(60) == 0)
            {
                Item.NewItem(npc.getRect(), ItemID.BlackLens, 1);
            }
            else if (Main.rand.Next(50) == 0)
            {
                Item.NewItem(npc.getRect(), mod.ItemType("BionicLens"), 1);
            }
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)   //Return a value between 0 and 1
        {
            return SpawnCondition.OverworldNightMonster.Chance;
		}
        
    }
}