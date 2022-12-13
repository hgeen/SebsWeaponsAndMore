using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using SebsWeaponsNMore.Items.Ammo;
using SebsWeaponsNMore.Items.Materials;
using SebsWeaponsNMore.Items.Weapons.Ranged;

namespace SebsWeaponsNMore.Items.Weapons.Ranged
{
    internal class M16A3 : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Full Auto");
            DisplayName.SetDefault("M16A3");
        }

        public override void SetDefaults()
        {
            Item.width = 38;
            Item.height = 10;
            Item.damage = 18;
            Item.DamageType = DamageClass.Ranged;
            Item.useStyle = 5;
            Item.knockBack = 1f;
            Item.value = 10000;
            Item.rare = ItemRarityID.Blue;
            Item.UseSound = SoundID.Item11;
            Item.autoReuse = true;
            Item.shoot = ProjectileID.WoodenArrowFriendly;
            Item.useAmmo = AmmoID.Bullet;
            Item.shootSpeed = 6.5f;
            Item.noMelee = true;
            Item.ArmorPenetration = 15;
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
            return Main.rand.NextFloat() >= 0.25f;
        }

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-6f, -2f);
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ModContent.ItemType<Spring>());
            recipe.AddIngredient(ModContent.ItemType<FiremodeChanger>(), 5);
            recipe.AddIngredient(ModContent.ItemType<M16A1>());
            recipe.AddTile(TileID.Anvils);
            recipe.Register();
        }
    }
}