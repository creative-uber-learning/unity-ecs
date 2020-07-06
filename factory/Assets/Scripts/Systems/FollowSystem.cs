using Unity.Entities;
using Unity.Transforms;
using Unity.Mathematics;
using Unity.Jobs;

public class FollowSystem : SystemBase
{
    protected override void OnUpdate()
    {
        Entities.ForEach((ref Motion motion, in Translation trans, in Target target) =>
        {
            float3 desiredVelocity = target.position - trans.Value;
            if (math.length(desiredVelocity) > 1)
                motion.velocity += math.normalize(desiredVelocity) - motion.velocity;
            else
                motion.velocity = desiredVelocity;
        })
        .ScheduleParallel();
    }
}