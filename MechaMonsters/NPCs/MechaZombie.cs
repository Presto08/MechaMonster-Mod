using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace MechaMonsters.NPCs
{
    public class MechaZombie : ModNPC // ModNPC is used for Custom NPCs
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Mech Zombie Mk1");
        }

        public override void SetDefaults()
        {
            npc.width = 18;
            npc.height = 40;
            npc.damage = 12;
            npc.defense = 5;
            npc.lifeMax = 150;
            npc.HitSound = SoundID.NPCHit4;
            npc.DeathSound = SoundID.NPCDeath2;
            npc.value = 100f;
            npc.knockBackResist = 0.95f;
            npc.aiStyle = 3;
            Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.Zombie]; //Main.npcFrameCount[3];
            aiType = NPCID.Zombie; // aiType = 3;
            animationType = NPCID.Zombie; // animationType = 3;
        }

        public override void NPCLoot()
        {
            if (Main.rand.Next(20) == 0)
            { 
                Item.NewItem(npc.getRect(), ItemID.IronBar, 2);
            }
            else if (Main.rand.Next(30) == 0)
            {
                Item.NewItem(npc.getRect(), ItemID.BlackLens, 1);
            }
            else if (Main.rand.Next(50) == 0)
            {
                Item.NewItem(npc.getRect(), mod.ItemType("BionicBoots"), 1);
            }
            else if (Main.rand.Next(50) == 0)
            {
                Item.NewItem(npc.getRect(), mod.ItemType("BionicFist"), 1);
            }
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)   //Return a value between 0 and 1
        {
            return SpawnCondition.OverworldNightMonster.Chance;
		}
        
    }
}