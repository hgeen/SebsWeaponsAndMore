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
    internal class AR10A1 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("AR-10A1");
        }

        public override void SetDefaults()
        {
            Item.width = 40;
            Item.height = 20;
            Item.damage = 57;
            Item.DamageType = DamageClass.Ranged;
            Item.useStyle = 5;
            Item.knockBack = 1f;
            Item.value = 10000;
            Item.rare = ItemRarityID.Purple;
            Item.UseSound = SoundID.Item38;
            Item.autoReuse = true;
            Item.shoot = ProjectileID.WoodenArrowFriendly;
            Item.useAmmo = AmmoID.Bullet;
            Item.shootSpeed = 106.5f;
            Item.noMelee = true;
            Item.ArmorPenetration = 50;
            Item.useAnimation = 9;
            Item.useTime = 9; // one third of useAnimation
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
            return Main.rand.NextFloat() >= 0.55f;
        }

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-20f, -2f);
        }

        public override void ModifyShootStats(Player player, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback)
        {
            velocity = velocity.RotatedByRandom(MathHelper.ToRadians(4));
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ModContent.ItemType<Spring>(), 5);
            recipe.AddIngredient(ModContent.ItemType<FiremodeChanger>());
            recipe.AddIngredient(ModContent.ItemType<SR25>());
            recipe.AddRecipeGroup("IronBar", 5);
            recipe.AddTile(TileID.Anvils);
            recipe.Register();
        }
    }
}