using RimWorld;
using UnityEngine;
using Verse;

namespace BuildLib;

public class Building_Gate : Building_Door
{
    private static int AlignQualityAgainst(IntVec3 c, Map map)
    {
        if (!c.InBounds(map))
        {
            return 0;
        }

        if (!c.Walkable(map))
        {
            return 9;
        }

        var thingList = c.GetThingList(map);
        foreach (var thing in thingList)
        {
            if (typeof(Building_Gate).IsAssignableFrom(thing.def.thingClass))
            {
                return 1;
            }

            Thing thing2 = thing as Blueprint;
            if (thing2 != null)
            {
                if (thing2.def.entityDefToBuild.passability > 0)
                {
                    return 9;
                }

                if (typeof(Building_Gate).IsAssignableFrom(thing.def.thingClass))
                {
                    return 1;
                }
            }

            if (thing.def.passability > 0)
            {
                return 9;
            }
        }

        return 0;
    }

    public static Rot4 DoorRotationAt(IntVec3 loc, Map map)
    {
        var num2 = 0;
        var num3 = AlignQualityAgainst(loc + IntVec3.East, map) + AlignQualityAgainst(loc + IntVec3.West, map);
        num2 += AlignQualityAgainst(loc + IntVec3.North, map);
        num2 += AlignQualityAgainst(loc + IntVec3.South, map);
        var result = num3 >= num2 ? Rot4.North : Rot4.East;

        return result;
    }

    protected override void DrawAt(Vector3 drawLoc, bool flip = false)
    {
        Rotation = DoorRotationAt(Position, Map);
        var num = Mathf.Clamp01(ticksSinceOpen / (float)TicksToOpenNow);
        var d = 0f + (0.45f * num);
        for (var i = 0; i < 2; i++)
        {
            Vector3 vector;
            Mesh mesh;
            if (i == 0)
            {
                vector = new Vector3(0f, 0f, -1f);
                mesh = MeshPool.plane10;
            }
            else
            {
                vector = new Vector3(0f, 0f, 1f);
                mesh = MeshPool.plane10Flip;
            }

            var rotation = Rotation;
            rotation.Rotate(RotationDirection.Clockwise);
            vector = rotation.AsQuat * vector;
            var vector2 = drawLoc;
            vector2.y = AltitudeLayer.Shadows.AltitudeFor();
            vector2 += vector * d;
            Graphics.DrawMesh(mesh, vector2, Rotation.AsQuat, Graphic.MatAt(Rotation), 0);
        }

        Comps_PostDraw();
    }
}