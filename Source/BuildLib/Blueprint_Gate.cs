using RimWorld;

namespace BuildLib;

public class Blueprint_Gate : Blueprint_Build
{
    public override void Draw()
    {
        Rotation = Building_Gate.DoorRotationAt(Position, Map);
        base.Draw();
    }
}