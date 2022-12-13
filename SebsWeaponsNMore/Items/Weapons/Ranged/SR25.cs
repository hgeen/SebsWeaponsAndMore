using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using SebsWeaponsNMore.Items.Ammo;
using SebsWeaponsNMore.Items.Materials;

namespace SebsWeaponsNMore.Items.Weapons.Ranged
{
    internal class SR25 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("SR-25");
        }

        public override void SetDefaults()
        {
            Item.width = 40;
            Item.height = 10;
            Item.damage = 131;
            Item.DamageType = DamageClass.Ranged;
            Item.useStyle = 5;
            Item.knockBack = 1f;
            Item.value = 10000;
            Item.rare = ItemRarityID.Purple;
            Item.UseSound = SoundID.Item38;
            Item.autoReuse = false;
            Item.shoot = ProjectileID.WoodenArrowFriendly;
            Item.useAmmo = AmmoID.Bullet;
            Item.shootSpeed = 106.5f;
            Item.noMelee = true;
            Item.ArmorPenetration = 50;
            Item.useAnimation = 25;
            Item.useTime = 25;
        }

        /*public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
        {
            int Proj = 1;
            for (int i = 0; i < Proj; i++)
            {
                Vector2 NewVelocyOffset = velocity.RotatedByRandom(MathHelper.ToRadians(0));
                Projectile.NewProjectile(source, position, NewVelocyOffset, type, damage, knockback, player.whoAmI);
                //Projectile.NewProjectile(source, position, velocity, ProjectileID.GrenadeI, damage, knockback, player.whoAmI);
            }
            return true;
        }*/

        public override bool CanConsumeAmmo(Item ammo, Player player)
        {
            return Main.rand.NextFloat() >= 0.7f;
        }

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-20f, -2f);
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ModContent.ItemType<Spring>(), 15);
            recipe.AddRecipeGroup("IronBar", 5);
            recipe.AddIngredient(ItemID.TitaniumOre, 10);
            recipe.AddTile(TileID.Anvils);
            recipe.Register();

            Recipe recipe2 = CreateRecipe();
            recipe2.AddIngredient(ModContent.ItemType<Spring>(), 15);
            recipe2.AddRecipeGroup("IronBar", 5);
            recipe2.AddIngredient(ItemID.AdamantiteOre, 10);
            recipe2.AddTile(TileID.Anvils);
            recipe2.Register();
        }
    }
}