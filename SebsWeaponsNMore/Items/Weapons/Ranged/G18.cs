using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;
using SebsWeaponsNMore.Items.Ammo;
using SebsWeaponsNMore.Items.Materials;

namespace SebsWeaponsNMore.Items.Weapons.Ranged
{
    public class G18 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Glock 18"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
        }

        public override void SetDefaults()
        {
            Item.damage = 3;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 40;
            Item.height = 40;
            Item.useTime = 7;
            Item.useAnimation = 7;
            Item.useStyle = 5;
            Item.knockBack = 1f;
            Item.value = 10000;
            Item.rare = 1;
            Item.UseSound = SoundID.Item11;
            Item.autoReuse = true;
            Item.shoot = ProjectileID.WoodenArrowFriendly;
            Item.useAmmo = AmmoID.Bullet;
            Item.shootSpeed = 6.5f;
            Item.noMelee = true;
            Item.ArmorPenetration = 10;
        }

        public override bool CanConsumeAmmo(Item ammo, Player player)
        {
            return Main.rand.NextFloat() >= 0.25f;
        }

        /*public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ModContent.ItemType<FiremodeChanger>());
            recipe.AddIngredient(ModContent.ItemType<G17>());
            recipe.AddTile(TileID.WorkBenches);
            recipe.Register();
        }*/
    }
}