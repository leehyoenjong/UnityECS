using Unity.Entities;
using Unity.Mathematics;

public struct SpawnerComponent : IComponentData
{
    public float2 SpawnPosition;    // 생성 위치
    public float SpawnTimer;        // 생성 타이머
    public float SpawnInterval;     // 생성 간격
    public Entity Prefab;           // 생성할 프리팹
}