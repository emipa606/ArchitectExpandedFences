using HarmonyLib;
using RimWorld;
using Verse;

namespace BuildLib;

public static class Patch_GenSpawn
{
    [HarmonyPatch(typeof(GenSpawn), nameof(GenSpawn.SpawningWipes))]
    public static class Postfix_SpawningWipes
    {
        private static void Postfix(ref bool __result, BuildableDef newEntDef, ThingDef oldEntDef)
        {
            if (__result)
            {
                return;
            }

            if (oldEntDef is not { IsBlueprint: true })
            {
                return;
            }

            if (newEntDef is not ThingDef { IsBlueprint: true } thingDef)
            {
                return;
            }

            if (thingDef.entityDefToBuild is not ThingDef
                {
                    building.canPlaceOverWall: true
                } || oldEntDef.entityDefToBuild is not ThingDef def)
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