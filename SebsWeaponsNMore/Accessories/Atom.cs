using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;
using Terraria.ID;

namespace SebsWeaponsNMore.Accessories
{
    internal class Atom : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Atom");
            Tooltip.SetDefault("50% more Critical Chances, 15% more damage, 8 more defense, 10 armor penetration");
            Main.RegisterItemAnimation(Item.type, new DrawAnimationVertical(7, 8));
            ItemID.Sets.AnimatesAsSoul[Item.type] = true;
        }

        public override void SetDefaults()
        {
            Item.width = 16;
            Item.height = 16;
            Item.rare = ItemRarityID.Expert;
            Item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetDamage(DamageClass.Generic) += 0.2f;
            player.GetCritChance(DamageClass.Generic) += 0.50f;
            player.GetArmorPenetration(DamageClass.Generic) += 10;
            player.statDefense += 10;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ModContent.ItemType<Nucleus>());
            recipe.AddIngredient(ModContent.ItemType<PairOfElectrons>());
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.Register();
        }
    }
}