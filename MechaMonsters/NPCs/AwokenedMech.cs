using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace MechaMonsters.NPCs
{
    public class AwokenedMech : ModNPC // ModNPC is used for Custom NPCs
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Awoken Mech");
        }

        public override void SetDefaults()
        {
            npc.width = 18;
            npc.height = 24;
            npc.damage = 20;
            npc.defense = 20;
            npc.lifeMax = 500;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath14;
            npc.value = 150f;
            npc.knockBackResist = 0.25f;
            npc.aiStyle = 3;
            Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.Zombie]; //Main.npcFrameCount[3];
            aiType = NPCID.Zombie; // aiType = 3;
            animationType = NPCID.Zombie; // animationType = 3;
        }

        public override void NPCLoot()
        {
             if (Main.rand.Next(5) == 0)
            {
                Item.NewItem(npc.getRect(), (ItemID.JungleSpores), 3);
            }
             else
            { 
                Item.NewItem(npc.getRect(), (ItemID.Vine), 3);
                Item.NewItem(npc.getRect(), (ItemID.IronBar), 2);

            }
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)   //Return a value between 0 and 1
        {
            if (!Main.dayTime && NPC.downedBoss2 && spawnInfo.player.ZoneJungle)
            {
                return .05f;
            }
            else
            {
                return 0f;
            }
        }
        
    }
}