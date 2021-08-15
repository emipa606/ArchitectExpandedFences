using HarmonyLib;
using RimWorld;
using Verse;

namespace BuildLib
{
    // Token: 0x02000007 RID: 7
    public static class Patch_GenSpawn
    {
        // Token: 0x02000009 RID: 9
        [HarmonyPatch(typeof(GenSpawn), "SpawningWipes")]
        public static class Postfix_SpawningWipes
        {
            // Token: 0x06000009 RID: 9 RVA: 0x0000243C File Offset: 0x0000063C
            private static void Postfix(ref bool __result, BuildableDef newEntDef, ThingDef oldEntDef)
            {
                if (__result)
                {
                    return;
                }

                if (oldEntDef is not {IsBlueprint: true})
                {
                    return;
                }

                if (newEntDef is not ThingDef {IsBlueprint: true} thingDef)
                {
                    return;
                }

                if (thingDef.entityDefToBuild is not ThingDef thingDef2 || thingDef2.building == null ||
                    !thingDef2.building.canPlaceOverWall || oldEntDef.entityDefToBuild is not ThingDef def)
                {
                    return;
                }

                if (def == ThingDefOf.Wall ||
                    def == FenceDefOf.Closeboard ||
                    def == FenceDefOf.Farm ||
                    def == FenceDefOf.Picket ||
                    def == FenceDefOf.Solid ||
                    def == FenceDefOf.TallChainLink ||
                    def == FenceDefOf.ShortBrick ||
                    def == FenceDefOf.TallBrick)
                {
                    __result = true;
                }
            }
        }
    }
}