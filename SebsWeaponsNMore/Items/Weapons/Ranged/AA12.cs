using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using SebsWeaponsNMore.Items.Materials;
using SebsWeaponsNMore.Projectiles.Ranged;

namespace SebsWeaponsNMore.Items.Weapons.Ranged
{
    public class AA12 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("AA-12");
        }

        public override void SetDefaults()
        {
            Item.width = 45; // Hitbox width of the item.
            Item.height = 15; // Hitbox height of the item.
            Item.rare = ItemRarityID.Green; // The color that the item's name will be in-game.
            Item.useTime = 15; // The item's use time in ticks (60 ticks == 1 second.)
            Item.useAnimation = 15; // The length of the item's use animation in ticks (60 ticks == 1 second.)
            Item.useStyle = ItemUseStyleID.Shoot; // How you use the item (swinging, holding out, etc.)
            Item.autoReuse = true; // Whether or not you can hold click to automatically use it again.
            Item.UseSound = SoundID.Item36; // The sound that this item plays when used.
            Item.DamageType = DamageClass.Ranged; // Sets the damage type to ranged.
            Item.damage = 27; // Sets the item's damage. Note that projectiles shot by this weapon will use its and the used ammunition's damage added together.
            Item.knockBack = 6f; // Sets the item's knockback. Note that projectiles shot by this weapon will use its and the used ammunition's knockback added together.
            Item.noMelee = true; // So the item's animation doesn't do damage.
            Item.shoot = ProjectileID.WoodenArrowFriendly; // For some reason, all the guns in the vanilla source have this.
            Item.shootSpeed = 20f; // The speed of the projectile (measured in pixels per frame.)
            Item.useAmmo = AmmoID.Bullet; // The "ammo Id" of the ammo item that this weapon uses. Ammo IDs are magic numbers that usually correspond to the item id of one item that most commonly represent the ammo type.
            Item.ArmorPenetration = 50;
        }

        public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
        {
            const int NumProjectiles = 10; // The humber of projectiles that this gun will shoot.

            for (int i = 0; i < NumProjectiles; i++)
            {
                Vector2 newVelocity = velocity.RotatedByRandom(MathHelper.ToRadians(15));

                newVelocity *= 1f - Main.rand.NextFloat(0.3f);

                Projectile.NewProjectileDirect(source, position, newVelocity, type, damage, knockback, player.whoAmI);
            }

            return false; // Return false because we don't want tModLoader to shoot projectile
        }

        public override void ModifyShootStats(Player player, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback)
        {
            if (type == ModContent.ProjectileType<M992>())
            {
                type = ModContent.ProjectileType<Millimeter>();
            }
            else if (type == ModContent.ProjectileType<X762>())
            {
                type = ModContent.ProjectileType<Millimeter>();
            }
            else if (type == ModContent.ProjectileType<SHARPS>())
            {
                type = ModContent.ProjectileType<Millimeter>();
            }
            else if (type == ModContent.ProjectileType<A556>())
            {
                type = ModContent.ProjectileType<Millimeter>();
            }
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.TacticalShotgun);
            recipe.AddIngredient(ItemID.Ectoplasm, 5);
            recipe.AddIngredient(ModContent.ItemType<FiremodeChanger>());
            recipe.AddIngredient(ModContent.ItemType<Spring>(), 5);
            recipe.AddTile(TileID.Anvils);
            recipe.Register();
        }

        // This method lets you adjust position of the gun in the player's hands. Play with these values until it looks good with your graphics.
        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-20f, -2f);
        }

        public override bool CanConsumeAmmo(Item ammo, Player player)
        {
            return Main.rand.NextFloat() >= 0.555f;
        }
    }
}