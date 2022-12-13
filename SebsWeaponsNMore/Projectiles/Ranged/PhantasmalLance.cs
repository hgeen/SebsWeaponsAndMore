using Terraria;
using System;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace SebsWeaponsNMore.Projectiles.Ranged
{
    public class PhantasmalLance : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Phantasmal Lance");
        }

        public override void SetDefaults()
        {
            Projectile.damage = 88;
            Projectile.DamageType = DamageClass.Ranged;
            Projectile.width = 102;
            Projectile.height = 10;
            Projectile.aiStyle = 0;
            Projectile.friendly = true;
            Projectile.penetrate = 5;
            Projectile.timeLeft = 1000;
            Projectile.light = 0f;
            Projectile.ignoreWater = true;
            Projectile.tileCollide = false;
        }

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            target.AddBuff(BuffID.Ichor, 30);
        }
    }
}