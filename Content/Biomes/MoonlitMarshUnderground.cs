using Terraria.ModLoader;

namespace Nightshade.Content.Biomes;

public sealed class MoonlitMarshUnderground : ModBiome
{
    public override int Music => MusicLoader.GetMusicSlot(Mod, "Assets/Sounds/Music/MarshUnderground");
}
