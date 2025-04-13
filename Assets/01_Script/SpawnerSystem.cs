using Unity.Burst;
using Unity.Entities;
using Unity.Transforms;

[BurstCompile]
public partial struct SpawnerSystem : ISystem
{
    [BurstCompile]
    public void OnUpdate(ref SystemState state)
    {
        foreach (var (spawner, transform) in SystemAPI.Query<RefRW<SpawnerComponent>, RefRW<LocalTransform>>())
        {
            spawner.ValueRW.SpawnTimer += SystemAPI.Time.DeltaTime;
            
            if (spawner.ValueRW.SpawnTimer >= spawner.ValueRW.SpawnInterval)
            {
                spawner.ValueRW.SpawnTimer = 0;
                
                var instance = state.EntityManager.Instantiate(spawner.ValueRW.Prefab);
                var instanceTransform = SystemAPI.GetComponentRW<LocalTransform>(instance);
                instanceTransform.ValueRW.Position = new(spawner.ValueRW.SpawnPosition.x, spawner.ValueRW.SpawnPosition.y, 0);
            }
        }
    }
}