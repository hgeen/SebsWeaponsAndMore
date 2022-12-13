using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using SebsWeaponsNMore.Projectiles.Ranged;

namespace SebsWeaponsNMore.Items.Ammo
{
    public class Sharps2545 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault(".25-45 Sharps");
            Tooltip.SetDefault("Fast bullet, Low armor penetration");
        }

        public override void SetDefaults()
        {
            Item.damage = 16;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 8;
            Item.height = 8;
            Item.maxStack = 9999;
            Item.consumable = true;
            Item.knockBack = 2f;
            Item.value = 10;
            Item.rare = 1;
            Item.consumable = true;
            Item.shoot = ModContent.ProjectileType<SHARPS>();
            Item.ammo = AmmoID.Bullet;
            Item.shootSpeed = 20f;
            Item.ArmorPenetration = 8;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.MusketBall, 50);
            recipe.AddIngredient(ItemID.IronOre, 1);
            recipe.AddTile(TileID.WorkBenches);
            recipe.ReplaceResult(this, 250);
            recipe.Register();

            Recipe recipe2 = CreateRecipe();
            recipe2.AddIngredient(ItemID.MusketBall, 50);
            recipe2.AddIngredient(ItemID.LeadOre, 1);
            recipe2.AddTile(TileID.WorkBenches);
            recipe2.ReplaceResult(this, 250);
            recipe2.Register();
        }
    }
}