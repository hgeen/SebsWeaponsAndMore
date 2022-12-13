using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace SebsWeaponsNMore.Items.Weapons.Ranged
{
    internal class M16A1 : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("3 round burst");
            DisplayName.SetDefault("M16A1");
        }

        public override void SetDefaults()
        {
            Item.width = 38;
            Item.height = 10;
            Item.damage = 15;
            Item.DamageType = DamageClass.Ranged;
            Item.useStyle = 5;
            Item.knockBack = 1f;
            Item.value = 10000;
            Item.rare = ItemRarityID.Blue;
            Item.UseSound = SoundID.Item11;
            Item.autoReuse = false;
            Item.shoot = ProjectileID.WoodenArrowFriendly;
            Item.useAmmo = AmmoID.Bullet;
            Item.shootSpeed = 6.5f;
            Item.noMelee = true;
            Item.ArmorPenetration = 15;
            Item.useAnimation = 12;
            Item.useTime = 4; // one third of useAnimation
            Item.reuseDelay = 14;
            Item.consumeAmmoOnLastShotOnly = true;
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
            return Main.rand.NextFloat() >= 0.50f;
        }

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-6f, -2f);
        }
    }
}