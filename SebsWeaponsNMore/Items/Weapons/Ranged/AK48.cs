using Terraria.ModLoader;
using Terraria.ID;
using Terraria;
using SebsWeaponsNMore.Items.Materials;
using Microsoft.Xna.Framework;

namespace SebsWeaponsNMore.Items.Weapons.Ranged
{
    internal class AK48 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("AK-48");
            Tooltip.SetDefault("Ammo is no longer an issue");
        }

        public override void SetDefaults()
        {
            Item.width = 35;
            Item.height = 12;
            Item.damage = 137;
            Item.DamageType = DamageClass.Ranged;
            Item.useTime = 7;
            Item.useAnimation = 7;
            Item.useStyle = 5;
            Item.knockBack = 1f;
            Item.value = 100000;
            Item.rare = ItemRarityID.Master;
            Item.UseSound = SoundID.Item12;
            Item.autoReuse = true;
            Item.shoot = ProjectileID.PurpleLaser;
            Item.useAmmo = AmmoID.Bullet;
            Item.shootSpeed = 50f;
            Item.noMelee = true;
            Item.ArmorPenetration = 100;
        }

        public override bool CanConsumeAmmo(Item ammo, Player player)
        {
            return Main.rand.NextFloat() >= 0.80f;
        }

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-6f, -2f);
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ModContent.ItemType<Spring>(), 5);
            recipe.AddIngredient(ModContent.ItemType<AK47>());
            recipe.AddIngredient(ModContent.ItemType<M16A3>());
            recipe.AddIngredient(ModContent.ItemType<M4A1>());
            recipe.AddIngredient(ModContent.ItemType<G18>());
            recipe.AddIngredient(ItemID.LunarOre, 10);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.Register();
        }
    }
}
