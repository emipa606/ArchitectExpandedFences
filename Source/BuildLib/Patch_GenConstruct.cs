using HarmonyLib;
using RimWorld;
using Verse;

namespace BuildLib;

public static class Patch_GenConstruct
{
    [HarmonyPatch(typeof(GenConstruct), "CanPlaceBlueprintOver")]
    public static class Postfix_CanPlaceBlueprintOver
    {
        private static void Postfix(ref bool __result, BuildableDef newDef, ThingDef oldDef)
        {
            if (__result)
            {
                return;
            }

            var thingDef = newDef as ThingDef;
            var buildableDef = GenConstruct.BuiltDefOf(oldDef);
            var thingDef2 = buildableDef as ThingDef;
            if (oldDef.category != ThingCategory.Building && !oldDef.IsBlueprint && !oldDef.IsFrame)
            {
                return;
            }

            if (thingDef == null)
            {
                return;
            }

            if (thingDef2 == null || thingDef.building is not { canPlaceOverWall: true })
            {
                return;
            }

            if (thingDef2.IsSmoothed || thingDef2 == ThingDefOf.Wall ||
                thingDef2 == FenceDefOf.Closeboard || thingDef2 == FenceDefOf.Farm ||
                thingDef2 == FenceDefOf.Picket || thingDef2 == FenceDefOf.Solid ||
                thingDef2 == FenceDefOf.TallChainLink ||
                thingDef2 == FenceDefOf.ShortBrick || thingDef2 == FenceDefOf.TallBrick)
            {
                __result = true;
            }
        }
    }
}