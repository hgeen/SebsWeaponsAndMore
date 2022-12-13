using Terraria.ModLoader;
using Terraria.ID;
using Terraria;
using SebsWeaponsNMore.Items.Materials;
using Microsoft.Xna.Framework;

namespace SebsWeaponsNMore.Items.Weapons.Ranged
{
    internal class AK47 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("AK-47");
        }

        public override void SetDefaults()
        {
            Item.width = 35;
            Item.height = 12;
            Item.damage = 57;
            Item.DamageType = DamageClass.Ranged;
            Item.useTime = 9;
            Item.useAnimation = 9;
            Item.useStyle = 5;
            Item.knockBack = 1f;
            Item.value = 10000;
            Item.rare = ItemRarityID.Green;
            Item.UseSound = SoundID.Item11;
            Item.autoReuse = true;
            Item.shoot = ProjectileID.WoodenArrowFriendly;
            Item.useAmmo = AmmoID.Bullet;
            Item.shootSpeed = 6.5f;
            Item.noMelee = true;
            Item.ArmorPenetration = 40;
        }

        public override bool CanConsumeAmmo(Item ammo, Player player)
        {
            return Main.rand.NextFloat() >= 0.66f;
        }

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-6f, -2f);
        }
    }
}
