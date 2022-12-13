using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using SebsWeaponsNMore.Projectiles.Ranged;

namespace SebsWeaponsNMore.Items.Ammo
{
    public class Pst : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("9x19 PST");
            Tooltip.SetDefault("I don't know why 5x more bullets are made with copper or tin");
        }

        public override void SetDefaults()
        {
            Item.damage = 11;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 8;
            Item.height = 8;
            Item.maxStack = 9999;
            Item.consumable = true;
            Item.knockBack = 1.5f;
            Item.value = 10;
            Item.rare = 1;
            Item.consumable = true;
            //Item.shoot = ProjectileID.Bullet;
            Item.shoot = ModContent.ProjectileType<Millimeter>();
            Item.ammo = AmmoID.Bullet;
            Item.shootSpeed = 8f;
            Item.ArmorPenetration = 5;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.MusketBall, 50);
            recipe.AddIngredient(ItemID.CopperOre, 1);
            recipe.AddTile(TileID.WorkBenches);
            recipe.ReplaceResult(this, 250);
            recipe.Register();

            Recipe recipe2 = CreateRecipe();
            recipe2.AddIngredient(ItemID.MusketBall, 50);
            recipe2.AddIngredient(ItemID.TinOre, 1);
            recipe2.AddTile(TileID.WorkBenches);
            recipe2.ReplaceResult(this, 250);
            recipe2.Register();
        }
    }
}