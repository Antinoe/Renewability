using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace Renewability
{
    [Label("Server Config")]
    public class RenewabilityConfig : ModConfig
    {
        //This is here for the Config to work at all.
        public override ConfigScope Mode => ConfigScope.ServerSide;
		
        public static RenewabilityConfig Instance;
		
	[Header("Scavenging")]
		
        [Label("Enable Scavenging")]
        [Tooltip("If false, Players cannot Right-Click certain tiles for resources.\n[Default: On]")]
        [DefaultValue(true)]
        public bool enableScavenging {get; set;}
		
        [Label("Scavenge from Common Plants")]
        [Tooltip("If false, Players cannot Scavenge from Common Plants, such as Grass and Mushrooms.\n[Default: On]")]
        [DefaultValue(true)]
        public bool enableScavengingFromCommonPlants {get; set;}
		
        [Label("Scavenge from Uncommon Plants")]
        [Tooltip("If false, Players cannot Scavenge from Uncommon Plants, such as Cattails, Lily Pads and Sea Oats.\n[Default: On]")]
        [DefaultValue(true)]
        public bool enableScavengingFromUncommonPlants {get; set;}
		
        [Label("[i:Hay] Scavenge Hay")]
        [Tooltip("[Default: On]")]
        [DefaultValue(true)]
        public bool enableScavengingHay {get; set;}
		
        [Label("[i:Cobweb] Scavenge Cobwebs")]
        [Tooltip("[Default: On]")]
        [DefaultValue(true)]
        public bool enableScavengingCobweb {get; set;}
		
        [Label("[i:Acorn] Scavenge Acorns")]
        [Tooltip("[Default: On]")]
        [DefaultValue(true)]
        public bool enableScavengingAcorn {get; set;}
		
        [Label("[i:GreenMoss] Scavenge Moss")]
        [Tooltip("[Default: On]")]
        [DefaultValue(true)]
        public bool enableScavengingMoss {get; set;}
		
        [Label("[i:Vine] Scavenge Vines")]
        [Tooltip("[Default: On]")]
        [DefaultValue(true)]
        public bool enableScavengingVine {get; set;}
		
        [Label("[i:HerbBag] Scavenge Herb Bags")]
        [Tooltip("[Default: On]")]
        [DefaultValue(true)]
        public bool enableScavengingHerbBag {get; set;}
		
		/*
        [Label("Scavenge from Common Plants")]
        [Tooltip("If false, Players cannot Scavenge from Common Plants, such as Grass and Mushrooms.\n[Default: On]")]
        [DefaultValue(true)]
        public bool enableScavengingFromCommonPlants {get; set;}
		
        [Label("Scavenge from Uncommon Plants")]
        [Tooltip("If false, Players cannot Scavenge from Uncommon Plants, such as Cattails, Lily Pads and Sea Oats.\n[Default: On]")]
        [DefaultValue(true)]
        public bool enableScavengingFromUncommonPlants {get; set;}
		
        [Label("[i:Hay] Hay Scavenge Chance")]
        [Tooltip("[Default: 4]")]
        [Slider]
        [DefaultValue(4)]
        [Range(1, 30)]
        [Increment(1)]
        public int scavengeChanceCommonPlantsHay {get; set;}
		
        [Label("[i:Cobweb] Cobweb Scavenge Chance")]
        [Tooltip("[Default: 10]")]
        [Slider]
        [DefaultValue(10)]
        [Range(1, 30)]
        [Increment(1)]
        public int scavengeChanceCommonPlantsCobweb {get; set;}
		
        [Label("[i:Acorn] Acorn Scavenge Chance")]
        [Tooltip("[Default: 20]")]
        [Slider]
        [DefaultValue(20)]
        [Range(1, 30)]
        [Increment(1)]
        public int scavengeChanceCommonPlantsAcorn {get; set;}
		
        [Label("[i:GreenMoss] Moss Scavenge Chance")]
        [Tooltip("[Default: 10]")]
        [Slider]
        [DefaultValue(10)]
        [Range(20, 200)]
        [Increment(20)]
        public int scavengeChanceCommonPlantsMoss {get; set;}
		
        [Label("[i:Vine] Vine Scavenge Chance")]
        [Tooltip("[Default: 80]")]
        [Slider]
        [DefaultValue(80)]
        [Range(20, 200)]
        [Increment(20)]
        public int scavengeChanceCommonPlantsVine {get; set;}
		
        [Label("[i:HerbBag] Herb Bag Scavenge Chance")]
        [Tooltip("[Default: 80]")]
        [Slider]
        [DefaultValue(160)]
        [Range(20, 200)]
        [Increment(20)]
        public int scavengeChanceCommonPlantsHerbBag {get; set;}
		*/
		
        [Label("Scavenge from Vines")]
        [Tooltip("[Default: Off]")]
        [DefaultValue(false)]
        public bool enableScavengingFromVines {get; set;}
		
        [Label("Scavenge for Fruits")]
        [Tooltip("If false, Players cannot Scavenge for Fruits from Common Plants.\n[Default: On]")]
        [DefaultValue(true)]
        public bool enableScavengingForFruits {get; set;}
		
        [Label("[i:Apple] Forest Fruit Scavenge Chance")]
        [Tooltip("Chance for Common Plants to drop fruit.\n[Default: 200]")]
        [Slider]
        [DefaultValue(200)]
        [Range(20, 300)]
        [Increment(20)]
        public int scavengeChanceFruitsForest {get; set;}
		
        [Label("[i:Mango] Jungle Fruit Scavenge Chance")]
        [Tooltip("Chance for Common Plants to drop fruit.\n[Default: 100]")]
        [Slider]
        [DefaultValue(100)]
        [Range(20, 300)]
        [Increment(20)]
        public int scavengeChanceFruitsJungle {get; set;}
		
        [Label("[i:Coconut] Palm Fruit Scavenge Chance")]
        [Tooltip("Chance for Common Plants to drop fruit.\n[Default: 100]")]
        [Slider]
        [DefaultValue(100)]
        [Range(20, 300)]
        [Increment(20)]
        public int scavengeChanceFruitsPalm {get; set;}
		
        [Label("[i:Elderberry] Corruption Fruit Scavenge Chance")]
        [Tooltip("Chance for Common Plants to drop fruit.\n[Default: 100]")]
        [Slider]
        [DefaultValue(100)]
        [Range(20, 300)]
        [Increment(20)]
        public int scavengeChanceFruitsCorruption {get; set;}
		
        [Label("[i:Rambutan] Crimson Fruit Scavenge Chance")]
        [Tooltip("Chance for Common Plants to drop fruit.\n[Default: 100]")]
        [Slider]
        [DefaultValue(100)]
        [Range(20, 300)]
        [Increment(20)]
        public int scavengeChanceFruitsCrimson {get; set;}
		
	[Header("Recipes")]
		
        [Label("[i:BottledWater] Enable Liquid Recipes")]
        [Tooltip("If true, the custom recipes of Liquids (Snow, Water, Lava and Honey) are enabled.\n(REQUIRES MOD RELOAD.)\n[Default: On]")]
        [DefaultValue(true)]
        public bool enableLiquids {get; set;}
		
        [Label("[i:SiltBlock] Enable Earthen Recipes")]
        [Tooltip("If true, the custom recipes of Earthen Materials (Ash, Silt, Sand, Stone, etc.) are enabled.\n(REQUIRES MOD RELOAD.)\n[Default: On]")]
        [DefaultValue(true)]
        public bool enableEarthen {get; set;}
		
        [Label("[i:Silk] Enable Fabric Recipes")]
        [Tooltip("If true, the custom recipes of Fabrics (Cobwebs, Tattered Cloth, Silk, Leather, etc.) are enabled.\n(REQUIRES MOD RELOAD.)\n[Default: On]")]
        [DefaultValue(true)]
        public bool enableFabrics {get; set;}
		
        [Label("[i:Apple] Enable Fruit Recipes")]
        [Tooltip("If true, the custom recipes of Fruits (Apples, Cherries, Mangos, Bananas, etc.) are enabled.\n(REQUIRES MOD RELOAD.)\n[Default: On]")]
        [DefaultValue(true)]
        public bool enableFruits {get; set;}
		
        [Label("[i:TinCan] Enable Recycle Recipes")]
        [Tooltip("If true, the custom recipes of Recycleables (Old Shoe, Tin Can, Seaweed) are enabled.\n(REQUIRES MOD RELOAD.)\n[Default: On]")]
        [DefaultValue(true)]
        public bool enableRecycle {get; set;}
		
        [Label("[i:WormTooth] Enable Organic Recipes")]
        [Tooltip("If true, the custom recipes of Organics (Worm Teeth) are enabled.\n(REQUIRES MOD RELOAD.)\n[Default: On]")]
        [DefaultValue(true)]
        public bool enableOrganics {get; set;}
		
        [Label("[i:BugNet] Enable Tool Recipes")]
        [Tooltip("If true, the custom recipes of Tools (Sickle, Bug Net) are enabled.\n(REQUIRES MOD RELOAD.)\n[Default: On]")]
        [DefaultValue(true)]
        public bool enableTools {get; set;}
		
        [Label("[i:BambooBlock] Enable Plant Recipes")]
        [Tooltip("If true, the custom recipes of Plants (Bamboo, Cacti) are enabled.\n(REQUIRES MOD RELOAD.)\n[Default: On]")]
        [DefaultValue(true)]
        public bool enablePlants {get; set;}
		
        [Label("[i:GrassSeeds] Enable Seed Recipes")]
        [Tooltip("If true, the custom recipes of various Seeds (Grass, Jungle Grass, Mushroom Grass, Corrupt, Crimson) are enabled.\n(REQUIRES MOD RELOAD.)\n[Default: On]")]
        [DefaultValue(true)]
        public bool enableSeeds {get; set;}
		
        [Label("[i:Waterleaf] Enable Herbal Flower Recipes")]
        [Tooltip("If true, the custom recipes of Herbal Flowers (Daybloom, Waterleaf, Blinkroot, etc.) are enabled.\n(REQUIRES MOD RELOAD.)\n[Default: On]")]
        [DefaultValue(true)]
        public bool enableHerbsFlowers {get; set;}
		
        [Label("[i:Mushroom] Enable Herbal Mushroom Recipes")]
        [Tooltip("If true, the custom recipes of Herbal Mushrooms (Mushroom, Vile Mushroom, Vicious Mushroom) are enabled.\n(REQUIRES MOD RELOAD.)\n[Default: On]")]
        [DefaultValue(true)]
        public bool enableHerbsMushrooms {get; set;}
		
        [Label("[i:Bomb] Enable Weapon Recipes")]
        [Tooltip("If true, the custom recipes of Weapons (Explosive Powder, Grenades, Bombs) are enabled.\n(REQUIRES MOD RELOAD.)\n[Default: On]")]
        [DefaultValue(true)]
        public bool enableWeapons {get; set;}
		
        [Label("[i:Extractinator] Enable Workstation Recipes")]
        [Tooltip("If true, the custom recipes of Workstations (Living Loom, Extractinator, Tinkerer's Workshop, Ice Machine) are enabled.\n(REQUIRES MOD RELOAD.)\n[Default: On]")]
        [DefaultValue(true)]
        public bool enableWorkstations {get; set;}
    }
}