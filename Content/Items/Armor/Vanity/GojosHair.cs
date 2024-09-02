﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NeviliscoVanity.Content.Items.Armor.Vanity
{
    [AutoloadEquip(EquipType.Head)]
    public class GojosHair : ModItem, ILocalizedModType
    {
        public new string LocalizationCategory => "Content.Items.Armor.Vanity";
        public override void SetDefaults()
        {
            Item.width = 24;
            Item.height = 20;
            Item.value = 0;
            Item.rare = ItemRarityID.Blue;
            Item.vanity = true;
        }

        public override void AddRecipes() => CreateRecipe().AddTile(TileID.Loom).Register();
    }
}
