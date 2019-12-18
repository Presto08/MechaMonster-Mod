using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace MechaMonsters.NPCs
{
    public class BrokenAncientMechaEye : ModNPC // ModNPC is used for Custom NPCs 
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Broken Ancient Mechanical Eye");  
        }

        public override void SetDefaults()
        {
            npc.width = 18;
            npc.height = 24;
            npc.damage = 10;
            npc.defense = 1;
            npc.lifeMax = 10;
            npc.HitSound = SoundID.NPCHit4;
            npc.DeathSound = SoundID.NPCDeath14;
            npc.value = 150f;
            npc.knockBackResist = 0.1f;
            npc.aiStyle = 1;
            Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.DemonEye]; //Main.npcFrameCount[2];
            aiType = NPCID.DemonEye; // aiType = 2;
            animationType = NPCID.DemonEye; // animationType = 2;aa
        }

        public override void NPCLoot()
        {
             if (Main.rand.Next(10) == 0) 
            {
                Item.NewItem(npc.getRect(), mod.ItemType("AncientTablet"), 1);
            }
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)   //Return a value between 0 and 1
        {
            return SpawnCondition.OverworldNightMonster.Chance * 0.5f;
		}
        
    }
}