using HarmonyLib;
using Verse;

namespace BuildLib;

[StaticConstructorOnStartup]
public static class HarmonyInit
{
    static HarmonyInit()
    {
        var harmony = new Harmony("Nif.ArchitectExpanded.Fences");
        harmony.PatchAll();
    }
}