using HarmonyLib;
using Verse;

namespace BuildLib;

[StaticConstructorOnStartup]
public static class HarmonyInit
{
    static HarmonyInit()
    {
        new Harmony("Nif.ArchitectExpanded.Fences").PatchAll();
    }
}