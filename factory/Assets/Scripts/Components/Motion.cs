using Unity.Entities;
using Unity.Mathematics;

[GenerateAuthoringComponent]
public struct Motion : IComponentData
{
    public float3 velocity;
    public float speed;
}
