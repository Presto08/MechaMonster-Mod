using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace MechaMonsters.NPCs
{
    public class AncientMechaEye : ModNPC // ModNPC is used for Custom NPCs
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ancient Mechanical Eye");
        }

        public override void SetDefaults()
        {
            npc.width = 18;
            npc.height = 24;
            npc.damage = 20;
            npc.defense = 10;
            npc.lifeMax = 100;
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
             if (Main.rand.Next(5) == 0)
            {
                Item.NewItem(npc.getRect(), mod.ItemType("AncientTablet"), 1);
            }
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)   //Return a value between 0 and 1
        {
            return Main.dayTime ? 0f : .03f;
        }

    }
}