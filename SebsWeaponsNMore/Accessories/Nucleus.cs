using System;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace SebsWeaponsNMore.Accessories
{
    internal class Nucleus : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Nucleus");
            Tooltip.SetDefault("10% more damage, 5 more defense");
        }

        public override void SetDefaults()
        {
            Item.width = 16;
            Item.height = 16;
            Item.rare = ItemRarityID.Red;
            Item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetDamage(DamageClass.Generic) += 0.10f;
            player.statDefense += 5;
        }
    }
}