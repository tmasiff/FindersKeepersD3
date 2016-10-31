﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace FindersKeepers
{
    public class ItemsTypesConversion
    {
        public static Dictionary<string, string> Conversion = new Dictionary<string, string>()
        {
            #region ConversionTable
            { "Weapon", "Weapon" },
            { "Melee", "Melee" },
            { "Swing", "Swing" },
            { "Axe", "Axe" },
            { "Axe2H", "Two-Handed Axe" },
            { "Club", "Club" },
            { "Sword", "Sword" },
            { "Sword2H", "Two-Handed Sword" },
            { "Hammer", "Hammer" },
            { "Hammer2H", "Two-Handed Hammer" },
            { "Mace", "Mace" },
            { "Mace2H", "Two-Handed Mace" },
            { "FistWeapon", "Fist Weapon" },
            { "CombatStaff", "Daibo" },
            { "Thrust", "Thrust" },
            { "Dagger", "Dagger" },
            { "Polearm", "Polearm" },
            { "Ranged", "Ranged" },
            { "BowClass", "Bow" },
            { "Bow", "Bow" },
            { "Starter-Bow", "Starter-Bow" },
            { "Crossbow", "Crossbow" },
            { "MagicClass", "MagicClass" },
            { "Wand", "Wand" },
            { "Staff", "Staff" },
            { "Thrown", "Thrown" },
            { "ThrowingAxe", "Throwing axe" },
            { "Spear", "Spear" },
            { "Armor", "Armor" },
            { "Shield", "Shield" },
            { "Helm", "Helm" },
            { "Gloves", "Gloves" },
            { "Boots", "Boots" },
            { "Shoulders", "Shoulders" },
            { "ChestArmor", "Chest Armor" },
            { "GenericBelt", "Belt" },
            { "Legs", "Pants" },
            { "Other", "Other" },
            { "Scroll", "Scroll" },
            { "TownPortalStone", "Town Portal Stone" },
            { "ScrollIdentify", "Scroll" },
            { "ScrollDispelCurse", "Scroll" },
            { "ScrollReverseCurse", "Scroll" },
            { "Potion", "Potion" },
            { "HealthPotion", "Potion" },
            { "ManaPotion", "Mana potion" },
            { "RejuvenationPotion", "Rejuvenation potion" },
            { "AntidotePotion", "Antidote potion" },
            { "Jewelry", "Jewelry" },
            { "Ring", "Ring" },
            { "Amulet", "Amulet" },
            { "Charm", "Charm" },
            { "Enchantment", "Enchantment" },
            { "Socketable", "Socketable" },
            { "Rune", "Rune" },
            { "Gem", "Gem" },
            { "Bloodstone", "Bloodstone" },
            { "Coral", "Coral" },
            { "Moonstone", "Moonstone" },
            { "Opal", "Opal" },
            { "Amber", "Amber" },
            { "Jade", "Jade" },
            { "Jet", "Jet" },
            { "Skull", "Skull" },
            { "Amethyst", "Amethyst" },
            { "Diamond", "Diamond" },
            { "Pearl", "Pearl" },
            { "Carnelian", "Carnelian" },
            { "Hematite", "Hematite" },
            { "Pyrite", "Pyrite" },
            { "Emerald", "Emerald" },
            { "Garnet", "Garnet" },
            { "Lapis", "Lapis" },
            { "Malachite", "Malachite" },
            { "Onyx", "Onyx" },
            { "Quartz", "Quartz" },
            { "Ruby", "Ruby" },
            { "Sapphire", "Sapphire" },
            { "Topaz", "Topaz" },
            { "Quest", "Quest" },
            { "Gold", "Gold" },
            { "All", "Other" },
            { "Quiver", "Quiver" },
            { "Orb", "Source" },
            { "ScrollOfPower", "Scroll" },
            { "ProtectionScroll", "Scroll" },
            { "DetectionScroll", "Scroll" },
            { "InvisibilityPotion", "Potion" },
            { "HearthScroll", "Scroll" },
            { "ElixirOfStrength", "ElixirOfStrength" },
            { "ElixirOfDexterity", "ElixirOfDexterity" },
            { "ElixirOfVitality", "ElixirOfVitality" },
            { "ElixirOfWillpower", "ElixirOfWillpower" },
            { "ElixirOfRegeneration", "ElixirOfRegeneration" },
            { "ElixirOfSuperiority", "ElixirOfSuperiority" },
            { "VialOfResurrection", "ItemTypeNames string: What is the item, basically? (Potion, Armor, Sword, etc.)" },
            { "ScrollWealth", "Scroll" },
            { "Runestone_A", "Crimson Runestone" },
            { "Runestone_B", "Indigo Runestone" },
            { "Runestone_C", "Obsidian Runestone" },
            { "Runestone_D", "Golden Runestone" },
            { "Runestone_E", "Alabaster Runestone" },
            { "Dye", "Dye" },
            { "ScrollDisenchant", "Scroll" },
            { "ScrollCalling", "Scroll" },
            { "ScrollGreed", "Scroll" },
            { "ScrollCompanion", "Scroll" },
            { "ScrollReforgeA", "Scroll" },
            { "ScrollReforgeB", "Scroll" },
            { "ScrollReforgeC", "Scroll" },
            { "TemplarSpecial", "Templar Relic" },
            { "ScoundrelSpecial", "Scoundrel Token" },
            { "EnchantressSpecial", "Enchantress Focus" },
            { "CraftingReagent", "Crafting Material" },
            { "Bracers", "Bracers" },
            { "HandXbow", "Hand Crossbow" },
            { "PageOfKnowledge", "Page" },
            { "Cloak", "Cloak" },
            { "CeremonialDagger", "Ceremonial Knife" },
            { "MightyWeapon1H", "Mighty Weapon" },
            { "SpiritStone_Monk", "Spirit Stone" },
            { "WizardHat", "Wizard Hat" },
            { "VoodooMask", "Voodoo Mask" },
            { "Belt_Barbarian", "Mighty Belt" },
            { "Mojo", "Mojo" },
            { "MightyWeapon2H", "Two-Handed Mighty Weapon" },
            { "PowerPotion", "Potion" },
            { "ProtectionPotion", "Potion" },
            { "PageOfRespec", "Page" },
            { "RespecTome", "Book" },
            { "TomeOfKnowledge", "Book" },
            { "GenericHelm", "Helm" },
            { "GenericBowWeapon", "Bow" },
            { "GenericThrustWeapon", "Weapon" },
            { "GenericSwingWeapon", "Weapon" },
            { "GenericChestArmor", "Chest Armor" },
            { "CraftingPlan", "Crafting Plan" },
            { "CraftingPlan_Smith", "Blacksmith Plan" },
            { "CraftingPlan_Jeweler", "Jeweler Design" },
            { "Elixir", "Elixir" },
            { "CraftingPlanLegendary_Smith", "Blacksmith Plan" },
            { "Belt", "Belt" },
            { "CrusaderShield", "Crusader Shield" },
            { "Flail1H", "Flail" },
            { "Flail2H", "Two-Handed Flail" },
            { "PageOfTraining_Jeweler", "Tome of Training" },
            { "PageOfTraining_Smith", "Tome of Training" },
            { "TrainingTome", "Tome of Training" },
            { "DemonicKey", "Key" },
            { "CraftingPlan_Mystic", "Mystic Formula" },
            { "ScrollBuff", "Scroll" },
            { "ScrollEnchant", "Enchantment Scroll" },
            { "ScrollProc", "Proc Scroll" },
            { "CraftingReagent_Bound", "Crafting Material" },
            { "Jewel", "Jewel" },
            { "PortalDevice", "Portal Device" },
            { "Shard", "Shard" },
            { "GreaterShard", "Greater Shard" },
            { "CraftingPlan_MysticTransmog", "Transmogrify Plan" },
            { "MysteryWeapon1H", "Weapon" },
            { "MysteryWeapon2H", "Weapon" },
            { "Helm_Wizard", "Helm" },
            { "Helm_Barbarian", "Helm" },
            { "Helm_DemonHunter", "Helm" },
            { "Helm_WitchDoctor", "Helm" },
            { "Helm_Monk", "Helm" },
            { "Helm_Crusader", "Helm" },
            { "ChestArmor_Barbarian", "Chest Armor" },
            { "ChestArmor_DemonHunter", "Chest Armor" },
            { "ChestArmor_Monk", "Chest Armor" },
            { "ChestArmor_Wizard", "Chest Armor" },
            { "ChestArmor_Crusader", "Chest Armor" },
            { "ChestArmor_WitchDoctor", "Chest Armor" },
            { "Shoulders_Barbarian", "Shoulders" },
            { "Shoulders_DemonHunter", "Shoulders" },
            { "Shoulders_Monk", "Shoulders" },
            { "Shoulders_Crusader", "Shoulders" },
            { "Shoulders_Wizard", "Shoulders" },
            { "Shoulders_WitchDoctor", "Shoulders" },
            { "Legs_Barbarian", "Pants" },
            { "Legs_Crusader", "Pants" },
            { "Legs_DemonHunter", "Pants" },
            { "Legs_Wizard", "Pants" },
            { "Legs_WitchDoctor", "Pants" },
            { "Legs_Monk", "Pants" },
            { "Boots_Barbarian", "Boots" },
            { "Boots_Crusader", "Boots" },
            { "Boots_DemonHunter", "Boots" },
            { "Boots_Monk", "Boots" },
            { "Boots_Wizard", "Boots" },
            { "Boots_WitchDoctor", "Boots" },
            { "Gloves_Barbarian", "Gloves" },
            { "Gloves_DemonHunter", "Gloves" },
            { "Gloves_Monk", "Gloves" },
            { "Gloves_Wizard", "Gloves" },
            { "Gloves_WitchDoctor", "Gloves" },
            { "Gloves_Crusader", "Gloves" },
            { "UpgradeableJewel", "Gem" },
            { "GeneralUtility", "Consumable" },
            { "HoradricReagent", "Horadric Reagent" },
            #endregion
        };

        public static string TryGet(string Name)
        {
            if (Conversion.ContainsKey(Name))
                return Conversion[Name];

            return "Unknown";
        }
    }

    public static class TextColors
    {
        public static Dictionary<string, System.Windows.Media.SolidColorBrush> Colors = new Dictionary<string, System.Windows.Media.SolidColorBrush>()
        {
            { "Normal" , Extensions.HexToColor("#ffffff") },
            { "Magic" , Extensions.HexToColor("#5883ff") },
            { "Rare" , Extensions.HexToColor("#ecb82c") },
            { "Legendary" , Extensions.HexToColor("#ff9b25") },
            { "Set" , Extensions.HexToColor("#00ff00") },
            { "Set2" , Extensions.HexToColor("#1d9f1d") },
        };

        public static System.Windows.Media.SolidColorBrush TryGet(string Key)
        {
            if (Colors.ContainsKey(Key))
                return Colors[Key];

            return Colors.FirstOrDefault().Value;
        }
    }

    public enum LegendaryItemsTypes
    {
        NotUsedTransmogOrConsole = -1,
        Amulet = -365243096,
        Axe_1H = 109694,
        Axe_2H = 119458520,
        Belt = 3635495,
        Belt_Barbarian = -479768568,
        Belt_Crusader = -1029603201,
        Belt_DemonHunter = 9087215,
        Belt_Monk = 1555631483,
        Belt_WitchDoctor = 994235600,
        Belt_Wizard = -2044734313,
        BloodShard = 1932948546,
        Boots = 120334087,
        Boots_Barbarian = -2097752600,
        Boots_Crusader = -1989686689,
        Boots_DemonHunter = -1038932273,
        Boots_Monk = 1931831131,
        Boots_WitchDoctor = -53783888,
        Boots_Wizard = -385210761,
        Bow = 110504,
        Bracer = -1999984446,
        Bracers_Barbarian = 1143143779,
        Bracers_Crusader = 60780154,
        Bracers_DemonHunter = 2129074442,
        Bracers_Monk = 1160852982,
        Bracers_WitchDoctor = -1180744469,
        Bracers_Wizard = 1833174994,
        CeremonialDagger = -199811863,
        Chest_Armor = -1028103400,
        ChestArmor_Barbarian = -1289348295,
        ChestArmor_Crusader = -1054135920,
        ChestArmor_DemonHunter = -1154939808,
        ChestArmor_Monk = 1667159564,
        ChestArmor_WitchDoctor = -169791423,
        ChestArmor_Wizard = -849738392,
        Cloak = 121411562,
        CombatStaff = -1620551894,
        Plan_Jeweler = 371712870,
        Plan_Mystic = 1323615825,
        Plan_MysticTransmog = 1295639964,
        Plan_Smith = -1515023331,
        PlanGeneric = 185803478,
        PlanLegendary = -1323275628,
        PlanLegendary_Smith = -1669219336,
        Crossbow = -1338851342,
        CrusaderShield = 602099538,
        Dagger = -262576534,
        Demonic_KeyP2 = -2019730316,
        Demonic_Key = -1979915768,
        Demonic_Organ = -49494186,
        EnchantressSpecial = -464307745,
        Fist_Weapon = -2094596416,
        Flail_1H = -1363671135,
        Flail_2H = -1363671102,
        FollowerSpecial = 1637769035,
        Gem = 115609,
        GenericBelt = -948083356,
        GenericBowWeapon = 395678127,
        GenericChestArmor = 828360981,
        GenericHelm = -947867741,
        GenericOffHand = 344906995,
        GenericRangedWeapon = 165564792,
        GenericSwingWeapon = 1846932879,
        GenericThrustWeapon = 998499313,
        Gloves = -131821392,
        Gloves_Barbarian = 444212945,
        Gloves_Crusader = 299901480,
        Gloves_DemonHunter = 1202607608,
        Gloves_Monk = 922698404,
        Gloves_WitchDoctor = -2107211303,
        Gloves_Wizard = 180877312,
        GreaterShard = 1331402556,
        HandXbow = 763102523,
        HealthPotion = -1916071921,
        Helm = 3851110,
        Helm_Barbarian = -1587563257,
        Helm_Crusader = -2104376930,
        Helm_DemonHunter = 506481070,
        Helm_Monk = 122656538,
        Helm_WitchDoctor = 1491629455,
        Helm_Wizard = 813646326,
        Pants = 3994699,
        Legs_Barbarian = -1177810900,
        Legs_Crusader = 1031652387,
        Legs_DemonHunter = 50199059,
        Legs_Monk = 1717378847,
        Legs_WitchDoctor = 1035347444,
        Legs_Wizard = -1995514053,
        Mace_1H = 4026134,
        Mace_2H = 89494384,
        Melee = 133016072,
        MightyWeapon_1H = -1488678091,
        MightyWeapon_2H = -1488678058,
        Mojo = 4041621,
        MysteryWeapon_1H = -241705760,
        MysteryWeapon_2H = -241705727,
        Gift = -1380314094,
        Offhand = -720431272,
        Orb = 124739,
        Polearm = -1203595600,
        Potion = 224120761,
        PowerPotion = -910124122,
        Quiver = 269990204,
        Ring = 4214896,
        ScoundrelSpecial = -953512528,
        Shard = 140227858,
        Shield = 332825721,
        Shoulders = -940830407,
        Shoulders_Barbarian = 1212065434,
        Shoulders_Crusader = 62868689,
        Shoulders_DemonHunter = -124654591,
        Shoulders_Monk = -821460787,
        Shoulders_WitchDoctor = 860493794,
        Shoulders_Wizard = -832936855,
        Spear = 140519163,
        Spirit_Stone = 576647032,
        Staff = 140658708,
        Swing = 140775496,
        Sword_1H = 140782159,
        Sword_2H = -1307049751,
        TemplarSpecial = 129668150,
        TreasureBag = 1650316949,
        Wand = 4385866,
        Wizard_Hat = -1499089042,
        Voodoo_Mask = -333341566,
        LegendaryGem = 1888008307,
        /* Not sure about*/
    }
}
