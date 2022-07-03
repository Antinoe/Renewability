using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Renewability.Content.Recipes
{
	public class Organics : ModSystem
	{
		public override void AddRecipes()
		{
			if (RenewabilityConfig.Instance.enableOrganics)
			{
				Recipe.Create(ItemID.RottenChunk,1)
				.AddIngredient(ItemID.WormTooth, 2)
				.AddTile(TileID.WorkBenches)
				.Register();
			}
        }
	}
}