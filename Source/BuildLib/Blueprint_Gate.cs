using RimWorld;

namespace BuildLib
{
    // Token: 0x02000002 RID: 2
    public class Blueprint_Gate : Blueprint_Build
    {
        // Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
        public override void Draw()
        {
            Rotation = Building_Gate.DoorRotationAt(Position, Map);
            base.Draw();
        }
    }
}