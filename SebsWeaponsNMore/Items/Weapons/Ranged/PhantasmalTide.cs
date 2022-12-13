using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using SebsWeaponsNMore.Projectiles.Ranged;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using System;
using Terraria.Localization;
using Terraria.Utilities;
using Terraria.GameContent.Bestiary;
using Terraria.GameContent.Personalities;
using System.Collections.Generic;
using Terraria.GameContent;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;

namespace SebsWeaponsNMore.Items.Weapons.Ranged
{
    public class PhantasmalTide : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Fires 8 Arrows");
        }

        public override void SetDefaults()
        {
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.damage = 80;
            Item.DamageType = DamageClass.Ranged;
            Item.useTime = 10;
            Item.autoReuse = true;
            Item.useAnimation = 10;
            Item.knockBack = 3f;
            Item.UseSound = SoundID.Item5;
            Item.rare = ItemRarityID.Expert;
            Item.useAmmo = AmmoID.Arrow;
            Item.shoot = ProjectileID.WoodenArrowFriendly;
            Item.shootSpeed = 40f;
            Item.noMelee = true;
            Item.expertOnly = true;
            Item.expert = true;
        }

        //public override void ModifyShootStats(Player player, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback)
        //{
            //if (type == ProjectileID.WoodenArrowFriendly)
            //{
                //type = ModContent.ProjectileType<SensicalProjectile>();
            //}
        //}

        public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
        {
            int Proj = 7;
            for (int i = 0; i < Proj; i++)
            {
                Vector2 NewVelocyOffset = velocity.RotatedByRandom(MathHelper.ToRadians(5));
                Projectile.NewProjectile(source, position, NewVelocyOffset, type, damage, knockback, player.whoAmI);
            }
            return true;
        }

        /*public override void PostDrawInWorld(SpriteBatch spriteBatch, Color lightColor, Color alphaColor, float rotation, float scale, int whoAmI)
        {
            Texture2D texture = ModContent.Request<Texture2D>("Testing/Items/Weapons/Ranged/PhantasmalTide_Glowmask", AssetRequestMode.ImmediateLoad).Value;
            spriteBatch.Draw
            (
                texture,
                new Vector2
                (
                    Item.position.X - Main.screenPosition.X + Item.width * 0.5f,
                    Item.position.Y - Main.screenPosition.Y + Item.height - texture.Height * 0.5f + 2f
                ),
                new Rectangle(0, 0, texture.Width, texture.Height),
                Color.Blue,
                rotation,
                texture.Size() * 0.5f,
                scale,
                SpriteEffects.None,
                0f
            );
        }*/

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.Phantasm, 1);
            recipe.AddIngredient(4953, 1);
            recipe.AddIngredient(ItemID.GravityGlobe, 1);
            recipe.AddTile(TileID.Furnaces);
            recipe.Register();
        }
    }
}
