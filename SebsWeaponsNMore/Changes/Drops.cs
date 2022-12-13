using Terraria.ID;
using Terraria.GameContent.ItemDropRules;
using Terraria.ModLoader;
using Terraria;
using SebsWeaponsNMore.Items.Weapons.Ranged;
using SebsWeaponsNMore.Accessories;

namespace SebsWeaponsNMore.Changes
{
    internal class NPCLOOT : GlobalNPC
    {
        public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
        {
            if (npc.type == NPCID.SnowFlinx)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<PairOfElectrons>(), 10, 1, 1));
            }
            else if (npc.type == NPCID.Piranha)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Nucleus>(), 10, 1, 1));
            }
            else if (npc.type == NPCID.AngryBones)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<G18>(), 49, 1, 1));
            }
            else if (npc.type == NPCID.AngryBonesBig)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<G18>(), 50, 1, 1));
            }
            else if (npc.type == NPCID.AngryBonesBigHelmet)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<G18>(), 50, 1, 1));
            }
            else if (npc.type == NPCID.AngryBonesBigMuscle)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<G18>(), 50, 1, 1));
            }
            else if (npc.type == NPCID.SkeletronHead)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<M16A1>(), 2, 1, 1));
            }
            else if (npc.type == NPCID.Gastropod)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<AK47>(), 33, 1, 1));
            }
        }
    }
}