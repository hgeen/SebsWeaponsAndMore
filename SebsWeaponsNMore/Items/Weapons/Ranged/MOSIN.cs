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
    internal class MOSIN : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Mosin Nagant");
        }

        public override void SetDefaults()
        {
            Item.width = 49;
            Item.height = 7;
            Item.damage = 97;
            Item.DamageType = DamageClass.Ranged;
            Item.useStyle = 5;
            Item.knockBack = 5f;
            Item.value = 10000;
            Item.rare = ItemRarityID.Blue;
            Item.UseSound = SoundID.Item38;
            Item.autoReuse = false;
            Item.shoot = ProjectileID.WoodenArrowFriendly;
            Item.useAmmo = AmmoID.Bullet;
            Item.shootSpeed = 50f;
            Item.noMelee = true;
            Item.ArmorPenetration = 25;
            Item.useAnimation = 31;
            Item.useTime = 31; // one third of useAnimation
        }

        public override bool CanConsumeAmmo(Item ammo, Player player)
        {
            return Main.rand.NextFloat() >= 0.25f;
        }

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-20f, -2f);
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ModContent.ItemType<Spring>(), 5);
            recipe.AddIngredient(ItemID.Wood, 50);
            recipe.AddRecipeGroup("IronBar", 10);
            recipe.AddIngredient(ItemID.Bone, 10);
            recipe.AddTile(TileID.Anvils);
            recipe.Register();
        }
    }
}