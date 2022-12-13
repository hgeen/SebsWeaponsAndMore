using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SebsWeaponsNMore.Items.Materials
{
    internal class Spring : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Used to create most of the guns");
        }

        public override void SetDefaults()
        {
            Item.width = 16;
            Item.height = 16;
            Item.material = true;
            Item.maxStack = 999;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.Chain, 2);
            recipe.AddTile(TileID.WorkBenches);
            recipe.Register();
        }
    }
}