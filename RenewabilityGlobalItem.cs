using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using System.IO;
using Terraria;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Terraria.Utilities;
using Terraria.ID;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Graphics;

namespace Renewability
{
    public class RenewabilityGlobalItem : GlobalItem
	{
        public override void SetDefaults(Item Item)
		{
			if (RenewabilityConfig.Instance.enableTools)
			{
				if (Item.type == ItemID.Sickle)
				{
						Item.damage = 5;
						Item.value = 500;
				}
			}
			if (RenewabilityConfig.Instance.enableWorkstations)
			{
				if (Item.type == ItemID.IceMachine)
				{
						Item.value = 1000;
				}
			}
			if (RenewabilityConfig.Instance.enableEarthen)
			{
				if (Item.type == ItemID.Coal)
				{
						Item.maxStack = 99;
				}
			}
			if (RenewabilityConfig.Instance.enableOrganics)
			{
				if (Item.type == ItemID.LivingLoom)
				{
						Item.value = 500;
				}
			}
		}
	}
}