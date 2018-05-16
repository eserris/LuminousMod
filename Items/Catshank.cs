using Terraria.ID;
using Terraria.ModLoader;

namespace LuminousMod.Items
{
	public class Catshank : ModItem
	{
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Catshank");
			Tooltip.SetDefault("The awesome power of cats fused into a sword.");
		}
		public override void SetDefaults()
		{
            item.CloneDefaults(ItemID.Meowmere);
			item.damage = 10000;
            
			//item.melee = true;
			//item.width = 40;
			//item.height = 40;
			item.useTime = 1;
			item.useAnimation = 16;
			//`item.useStyle = 1;
			item.knockBack = 10;
			//item.value = 10000;
			//item.rare = 100;
            item.UseSound = SoundID.Item8;
			item.autoReuse = true;
            
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 10);
            //recipe.AddIngredient(ItemID.LunarBar, 300);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
            
            ModRecipe rcat = new ModRecipe(mod);
            rcat.AddIngredient(ItemID.DirtBlock, 1);
            rcat.AddTile(TileID.WorkBenches);
            rcat.SetResult(ItemID.SolarFlareBreastplate);
            rcat.AddRecipe();

            ModRecipe zap = new ModRecipe(mod);
            zap.AddIngredient(ItemID.DirtBlock, 1);
            zap.AddTile(TileID.WorkBenches);
            zap.SetResult(ItemID.SolarFlareHelmet);
            zap.AddRecipe();

            ModRecipe izap = new ModRecipe(mod);
            izap.AddIngredient(ItemID.DirtBlock, 1);
            izap.AddTile(TileID.WorkBenches);
            izap.SetResult(ItemID.SolarFlareLeggings);
            izap.AddRecipe();
        }
	}
}
