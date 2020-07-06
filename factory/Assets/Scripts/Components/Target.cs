using Unity.Entities;
using Unity.Mathematics;

[GenerateAuthoringComponent]
public struct Target : IComponentData
{
    public float3 position;
    // TODO public Entity id;
}
