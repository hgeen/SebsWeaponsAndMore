using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using SebsWeaponsNMore.Items.Materials;

namespace SebsWeaponsNMore.Items.Materials
{
    internal class FiremodeChanger : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Used to convert Glock 17 into Glock 18");
        }

        public override void SetDefaults()
        {
            Item.width = 16;
            Item.height = 16;
            Item.material = true;
            Item.maxStack = 1;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.Bone, 10);
            recipe.AddIngredient(ItemID.Chain, 2);
            recipe.AddIngredient(ModContent.ItemType<Spring>());
            recipe.AddRecipeGroup("IronBar");
            recipe.AddTile(TileID.WorkBenches);
            recipe.Register();
        }
    }
}