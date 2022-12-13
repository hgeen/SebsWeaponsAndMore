using IL.Terraria.GameContent.Bestiary;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using SebsWeaponsNMore.Projectiles.Ranged;

namespace SebsWeaponsNMore.Items.Ammo
{
    public class M993 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("M993");
            Tooltip.SetDefault("High Penetration, High Damage, High Speed");
        }

        public override void SetDefaults()
        {
            Item.damage = 28;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 8;
            Item.height = 8;
            Item.maxStack = 9999;
            Item.consumable = true;
            Item.knockBack = 3f;
            Item.value = 10;
            Item.rare = 1;
            Item.consumable = true;
            Item.shoot = ModContent.ProjectileType<M992>();
            Item.ammo = AmmoID.Bullet;
            Item.shootSpeed = 100f;
            Item.ArmorPenetration = 40;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.MusketBall, 50);
            recipe.AddIngredient(ItemID.PlatinumOre);
            recipe.AddIngredient(ItemID.LeadOre);
            recipe.AddTile(TileID.WorkBenches);
            recipe.ReplaceResult(this, 250);
            recipe.Register();

            Recipe recipe2 = CreateRecipe();
            recipe2.AddIngredient(ItemID.MusketBall, 50);
            recipe2.AddIngredient(ItemID.GoldOre);
            recipe2.AddIngredient(ItemID.IronOre);
            recipe2.AddTile(TileID.WorkBenches);
            recipe2.ReplaceResult(this, 250);
            recipe2.Register();

            Recipe recipe3 = CreateRecipe();
            recipe3.AddIngredient(ItemID.MusketBall, 50);
            recipe3.AddIngredient(ItemID.PlatinumOre);
            recipe3.AddIngredient(ItemID.IronOre);
            recipe3.AddTile(TileID.WorkBenches);
            recipe3.ReplaceResult(this, 250);
            recipe3.Register();

            Recipe recipe4 = CreateRecipe();
            recipe4.AddIngredient(ItemID.MusketBall, 50);
            recipe4.AddIngredient(ItemID.GoldOre);
            recipe4.AddIngredient(ItemID.LeadOre);
            recipe4.AddTile(TileID.WorkBenches);
            recipe4.ReplaceResult(this, 250);
            recipe4.Register();
        }
    }
}