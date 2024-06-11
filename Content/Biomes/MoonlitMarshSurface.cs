using Terraria;
using Terraria.ModLoader;

namespace Nightshade.Content.Biomes;

public sealed class MoonlitMarshSurface : ModBiome
{
    /// <summary>
    ///     Whether the selected music track is an alternate version or not.
    /// </summary>
    public bool MusicAlternate { get; private set; }

    /// <summary>
    ///     The path to the current music track.
    /// </summary>
    public string MusicPath => Main.dayTime 
        ? "Assets/Sounds/Music/Marsh" + (MusicAlternate ? "Alt" : "Day") 
        : "Assets/Sounds/Music/MarshNight";
    
    public override int Music => MusicLoader.GetMusicSlot(Mod, MusicPath);
}
