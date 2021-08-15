using HarmonyLib;
using Verse;

namespace BuildLib
{
    // Token: 0x02000005 RID: 5
    [StaticConstructorOnStartup]
    public static class HarmonyInit
    {
        // Token: 0x06000007 RID: 7 RVA: 0x00002340 File Offset: 0x00000540
        static HarmonyInit()
        {
            var harmony = new Harmony("Nif.ArchitectExpanded.Fences");
            harmony.PatchAll();
        }
    }
}