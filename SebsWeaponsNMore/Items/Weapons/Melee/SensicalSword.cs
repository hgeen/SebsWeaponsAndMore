using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using SebsWeaponsNMore.Projectiles.Melee;

namespace SebsWeaponsNMore.Items.Weapons.Melee
{
    public class SensicalSword : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("SensicalSword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("Shoots a beam and penetrates a number of enemies I forgot");
        }

        public override void SetDefaults()
        {
            Item.damage = 67;
            Item.DamageType = DamageClass.Melee;
            Item.width = 40;
            Item.height = 40;
            Item.useTime = 14;
            Item.useAnimation = 14;
            Item.useStyle = 1;
            Item.knockBack = 3;
            Item.value = 666999;
            Item.rare = 2;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
            Item.shoot = ModContent.ProjectileType<SensicalProjectile>();
            Item.shootSpeed = 10f;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.IronBar, 5);
            recipe.AddIngredient(ItemID.MeteoriteBar, 10);
            recipe.AddIngredient(ItemID.CobaltBar, 10);
            recipe.AddIngredient(ItemID.Obsidian, 25);
            recipe.AddIngredient(ItemID.HallowedBar, 5);
            recipe.AddTile(TileID.Anvils);
            recipe.Register();

            Recipe recipe_palladium = CreateRecipe();
            recipe_palladium.AddIngredient(ItemID.LeadBar, 5);
            recipe_palladium.AddIngredient(ItemID.MeteoriteBar, 10);
            recipe_palladium.AddIngredient(ItemID.PalladiumBar, 10);
            recipe_palladium.AddIngredient(ItemID.Obsidian, 25);
            recipe_palladium.AddIngredient(ItemID.HallowedBar, 5);
            recipe_palladium.AddTile(TileID.Anvils);
            recipe_palladium.Register();
        }
    }
}