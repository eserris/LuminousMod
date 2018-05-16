using Terraria.ID;
using Terraria.ModLoader;

namespace LuminousMod.Items
{
    public class LuminousPlate : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Luminious Plate");
            Tooltip.SetDefault("It glows with celestial energy ");
        }
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.StardustBreastplate);
            item.defense = 2000;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.LunarBar, 300);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}