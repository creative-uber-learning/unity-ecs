using Unity.Entities;
using Unity.Transforms;
using Unity.Mathematics;
using Unity.Jobs;

public class MovementSystem : SystemBase
{
    protected override void OnUpdate()
    {
        float dt = Time.DeltaTime;

        Entities.ForEach((ref Translation trans, in Motion motion) =>
        {
            trans.Value += motion.velocity * motion.speed * dt;
        })
        .ScheduleParallel();
    }
}