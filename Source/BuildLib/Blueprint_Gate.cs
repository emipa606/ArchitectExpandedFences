using RimWorld;
using UnityEngine;

namespace BuildLib;

public class Blueprint_Gate : Blueprint_Build
{
    protected override void DrawAt(Vector3 drawLoc, bool flip = false)
    {
        Rotation = Building_Gate.DoorRotationAt(Position, Map);
        base.DrawAt(drawLoc, flip);
    }
}