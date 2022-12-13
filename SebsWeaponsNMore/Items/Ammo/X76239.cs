using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using SebsWeaponsNMore.Projectiles.Ranged;

namespace SebsWeaponsNMore.Items.Ammo
{
    public class X76239 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("7.62x39");
            Tooltip.SetDefault("High Penetration, High Damage, Low Speed");
        }

        public override void SetDefaults()
        {
            Item.damage = 21;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 8;
            Item.height = 8;
            Item.maxStack = 9999;
            Item.consumable = true;
            Item.knockBack = 3f;
            Item.value = 10;
            Item.rare = 1;
            Item.consumable = true;
            Item.shoot = ModContent.ProjectileType<X762>();
            Item.ammo = AmmoID.Bullet;
            Item.shootSpeed = 10f;
            Item.ArmorPenetration = 25;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.MusketBall, 50);
            recipe.AddIngredient(ItemID.GoldOre, 1);
            recipe.AddTile(TileID.WorkBenches);
            recipe.ReplaceResult(this, 250);
            recipe.Register();

            Recipe recipe2 = CreateRecipe();
            recipe2.AddIngredient(ItemID.MusketBall, 50);
            recipe2.AddIngredient(ItemID.PlatinumOre, 1);
            recipe2.AddTile(TileID.WorkBenches);
            recipe2.ReplaceResult(this, 250);
            recipe2.Register();
        }
    }
}