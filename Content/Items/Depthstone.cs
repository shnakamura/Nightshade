using Terraria.ID;
using Terraria.ModLoader;

namespace Nightshade.Content.Items;

public class Depthstone : ModItem
{
    public override void SetDefaults() {
        Item.DefaultToPlaceableTile(ModContent.TileType<Content.Tiles.Depthstone>());
    }
}
