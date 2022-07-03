using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace Renewability
{
	public class RenewabilityRecipeGroups : ModSystem
	{
		public override void AddRecipeGroups()
		{
		//Moss
			RecipeGroup group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Moss", new int[]
			{
				ItemID.GreenMoss,
				ItemID.BrownMoss,
				ItemID.BlueMoss,
				ItemID.PurpleMoss,
				ItemID.LavaMoss,
				ItemID.KryptonMoss,
				ItemID.XenonMoss,
				ItemID.ArgonMoss
			});
			RecipeGroup.RegisterGroup("Renewability:Moss", group);
		}
	}
}