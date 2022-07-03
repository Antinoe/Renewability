using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.DataStructures;
using Terraria.ModLoader;
using Terraria.Audio;

namespace Renewability
{
    public class RenewabilityGlobalTile : GlobalTile
	{
        //public override void RightClick(int i, int j, int type)
		public override void KillTile(int i, int j, int type, ref bool fail, ref bool effectOnly, ref bool noItem)
		{
			if (RenewabilityConfig.Instance.enableScavenging)
			{
				if (RenewabilityConfig.Instance.enableScavengingFromCommonPlants)
				{
					//Common Plants.
					if (type == TileID.Plants || type == TileID.Plants2 || type == TileID.JunglePlants || type == TileID.JunglePlants2 || type == TileID.MushroomPlants || type == TileID.CorruptPlants || type == TileID.CrimsonPlants)
					{
						//WorldGen.KillTile(i, j);
						if (Main.rand.Next(RenewabilityConfig.Instance.scavengeChanceCommonPlantsHay) == 0)
						{
							Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 32, 32, ItemID.Hay, 1);
						}
						if (Main.rand.Next(RenewabilityConfig.Instance.scavengeChanceCommonPlantsCobweb) == 0)
						{
							Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 32, 32, ItemID.Cobweb, 1);
						}
						if (Main.rand.Next(RenewabilityConfig.Instance.scavengeChanceCommonPlantsAcorn) == 0)
						{
							Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 32, 32, ItemID.Acorn, 1);
						}
						if (Main.rand.Next(RenewabilityConfig.Instance.scavengeChanceCommonPlantsVine) == 0)
						{
							Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 32, 32, ItemID.Vine, 1);
						}
						if (Main.rand.Next(RenewabilityConfig.Instance.scavengeChanceCommonPlantsHerbBag) == 0)
						{
							Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 32, 32, ItemID.HerbBag, 1);
						}
						if (type == TileID.Plants || type == TileID.Plants2)
						{
							if (Main.rand.Next(RenewabilityConfig.Instance.scavengeChanceCommonPlantsMoss) == 0)
							{
								Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 32, 32, ItemID.GreenMoss, 1);
							}
							if (RenewabilityConfig.Instance.enableScavengingForFruits)
							{
								if (Main.rand.Next(RenewabilityConfig.Instance.scavengeChanceFruitsForest) == 0)
								{
									Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 32, 32, ItemID.Apple, 1);
								}
								if (Main.rand.Next(RenewabilityConfig.Instance.scavengeChanceFruitsForest) == 0)
								{
									Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 32, 32, ItemID.Apricot, 1);
								}
								if (Main.rand.Next(RenewabilityConfig.Instance.scavengeChanceFruitsForest) == 0)
								{
									Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 32, 32, ItemID.Grapefruit, 1);
								}
								if (Main.rand.Next(RenewabilityConfig.Instance.scavengeChanceFruitsForest) == 0)
								{
									Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 32, 32, ItemID.Lemon, 1);
								}
								if (Main.rand.Next(RenewabilityConfig.Instance.scavengeChanceFruitsForest) == 0)
								{
									Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 32, 32, ItemID.Peach, 1);
								}
							}
						}
						if (type == TileID.JunglePlants || type == TileID.JunglePlants2)
						{
							if (Main.rand.Next(RenewabilityConfig.Instance.scavengeChanceCommonPlantsMoss) == 0)
							{
								Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 32, 32, ItemID.BrownMoss, 1);
							}
							if (RenewabilityConfig.Instance.enableScavengingForFruits)
							{
								if (Main.rand.Next(RenewabilityConfig.Instance.scavengeChanceFruitsJungle) == 0)
								{
									Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 32, 32, ItemID.Mango, 1);
								}
								if (Main.rand.Next(RenewabilityConfig.Instance.scavengeChanceFruitsJungle) == 0)
								{
									Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 32, 32, ItemID.Pineapple, 1);
								}
							}
						}
						if (type == TileID.MushroomPlants)
						{
							if (Main.rand.Next(RenewabilityConfig.Instance.scavengeChanceCommonPlantsMoss) == 0)
							{
								Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 32, 32, ItemID.BlueMoss, 1);
							}
						}
						if (type == TileID.CorruptPlants)
						{
							if (Main.rand.Next(RenewabilityConfig.Instance.scavengeChanceCommonPlantsMoss) == 0)
							{
								Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 32, 32, ItemID.PurpleMoss, 1);
							}
							if (RenewabilityConfig.Instance.enableScavengingForFruits)
							{
								if (Main.rand.Next(RenewabilityConfig.Instance.scavengeChanceFruitsCorruption) == 0)
								{
									Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 32, 32, ItemID.BlackCurrant, 1);
								}
								if (Main.rand.Next(RenewabilityConfig.Instance.scavengeChanceFruitsCorruption) == 0)
								{
									Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 32, 32, ItemID.Elderberry, 1);
								}
							}
						}
						if (type == TileID.CrimsonPlants)
						{
							if (Main.rand.Next(RenewabilityConfig.Instance.scavengeChanceCommonPlantsMoss) == 0)
							{
								Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 32, 32, ItemID.RedMoss, 1);
							}
							if (RenewabilityConfig.Instance.enableScavengingForFruits)
							{
								if (Main.rand.Next(RenewabilityConfig.Instance.scavengeChanceFruitsCrimson) == 0)
								{
									Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 32, 32, ItemID.BloodOrange, 1);
								}
								if (Main.rand.Next(RenewabilityConfig.Instance.scavengeChanceFruitsCrimson) == 0)
								{
									Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 32, 32, ItemID.Rambutan, 1);
								}
							}
						}
					}
				}
				//Uncommon Plants.
				if (RenewabilityConfig.Instance.enableScavengingFromUncommonPlants)
				{
					if (type == TileID.SeaOats || type == TileID.Cattail || type == TileID.LilyPad)
					{
						//WorldGen.KillTile(i, j);
						if (Main.rand.Next(RenewabilityConfig.Instance.scavengeChanceUncommonPlantsHay) == 0)
						{
							Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 32, 32, ItemID.Hay, 1);
						}
						if (Main.rand.Next(RenewabilityConfig.Instance.scavengeChanceUncommonPlantsCobweb) == 0)
						{
							Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 32, 32, ItemID.Cobweb, 1);
						}
						if (Main.rand.Next(RenewabilityConfig.Instance.scavengeChanceUncommonPlantsAcorn) == 0)
						{
							Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 32, 32, ItemID.Acorn, 1);
						}
						if (Main.rand.Next(RenewabilityConfig.Instance.scavengeChanceUncommonPlantsVine) == 0)
						{
							Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 32, 32, ItemID.Vine, 1);
						}
						if (Main.rand.Next(RenewabilityConfig.Instance.scavengeChanceUncommonPlantsHerbBag) == 0)
						{
							Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 32, 32, ItemID.HerbBag, 1);
						}
						if (type == TileID.SeaOats)
						{
							if (RenewabilityConfig.Instance.enableScavengingForFruits)
							{
								if (Main.rand.Next(RenewabilityConfig.Instance.scavengeChanceFruitsPalm) == 0)
								{
									Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 32, 32, ItemID.Banana, 1);
								}
								if (Main.rand.Next(RenewabilityConfig.Instance.scavengeChanceFruitsPalm) == 0)
								{
									Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 32, 32, ItemID.Coconut, 1);
								}
							}
						}
					}
				}
				//Vines.
				if (RenewabilityConfig.Instance.enableScavengingFromVines)
				{
					if (type == TileID.Vines || type == TileID.VineFlowers || type == TileID.JungleVines || type == TileID.MushroomVines || type == TileID.CrimsonVines)
					{
						//WorldGen.KillTile(i, j);
						if (Main.rand.Next(RenewabilityConfig.Instance.scavengeChanceCommonPlantsVine) == 0)
						{
							Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 32, 32, ItemID.Vine, 1);
						}
						if (Main.rand.Next(RenewabilityConfig.Instance.scavengeChanceCommonPlantsHay) == 0)
						{
							Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 32, 32, ItemID.Hay, 1);
						}
						if (Main.rand.Next(RenewabilityConfig.Instance.scavengeChanceCommonPlantsCobweb) == 0)
						{
							Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 32, 32, ItemID.Cobweb, 1);
						}
						if (type == TileID.VineFlowers)
						{
							if (Main.rand.Next(RenewabilityConfig.Instance.scavengeChanceCommonPlantsHerbBag) == 0)
							{
								Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 32, 32, ItemID.HerbBag, 1);
							}
						}
						if (type == TileID.JungleVines)
						{
							if (Main.rand.Next(RenewabilityConfig.Instance.scavengeChanceCommonPlantsMoss) == 0)
							{
								Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 32, 32, ItemID.BrownMoss, 1);
							}
						}
						if (type == TileID.MushroomVines)
						{
							if (Main.rand.Next(RenewabilityConfig.Instance.scavengeChanceCommonPlantsMoss) == 0)
							{
								Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 32, 32, ItemID.BlueMoss, 1);
							}
						}
						if (type == TileID.CrimsonVines)
						{
							if (Main.rand.Next(RenewabilityConfig.Instance.scavengeChanceCommonPlantsMoss) == 0)
							{
								Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 32, 32, ItemID.RedMoss, 1);
							}
						}
					}
				}
			}
		}
	}
}