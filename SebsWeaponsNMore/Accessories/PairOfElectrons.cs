using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;
using Terraria.ID;

namespace SebsWeaponsNMore.Accessories
{
    internal class PairOfElectrons : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Pair of Electrons");
            Tooltip.SetDefault("8% more Critical Chances, 5% more damage, 4 more defense, 5 armor penetration");
            Main.RegisterItemAnimation(Item.type, new DrawAnimationVertical(7, 8));
            ItemID.Sets.AnimatesAsSoul[Item.type] = true;
        }

        public override void SetDefaults()
        {
            Item.width = 16;
            Item.height = 16;
            Item.rare = ItemRarityID.Cyan;
            Item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetDamage(DamageClass.Generic) += 0.05f;
            player.GetCritChance(DamageClass.Generic) += 0.25f;
            player.GetArmorPenetration(DamageClass.Generic) += 5;
            player.statDefense += 4;
        }
    }
}