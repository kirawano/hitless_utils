using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace hitless_utils.Content.Items
{
    public class test_item : ModItem 
    {
	public override void SetDefaults ()
	{
        Item.damage = 0;
        Item.DamageType = DamageClass.Summon;
		Item.width = 40;
		Item.height = 40;
		Item.useTime = 20;
		Item.useAnimation = 20;
        Item.knockBack = 0;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.value = Item.buyPrice(silver: 1);
		Item.rare = ItemRarityID.Red;
		Item.UseSound = SoundID.Item1;
		Item.autoReuse = true;
	}

        public override void UpdateInventory (Player player)
        {
            player.AddBuff(50, 1);
        }

        public override void AddRecipes ()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.DirtBlock, 10);
	    recipe.AddTile(TileID.WorkBenches);
            recipe.Register();
        }
    }
}
