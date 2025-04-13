using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

// MonoBehaviour를 상속받아 Unity 에디터에서 설정 가능한 컴포넌트
public class SpawnerAuthoring : MonoBehaviour
{
    public float2 SpawnPosition;    // 생성될 위치 (x,y 좌표)
    public float SpawnInterval = 1f; // 생성 간격 (기본값 1초)
    public GameObject Prefab;       // 생성할 프리팹 객체
}

// Entity로 변환을 담당하는 Baker 클래스
public class SpawnerBaker : Baker<SpawnerAuthoring>
{
    public override void Bake(SpawnerAuthoring authoring)
    {
        // MonoBehaviour의 데이터를 Entity Component로 변환
        AddComponent(new SpawnerComponent
        {
            SpawnPosition = authoring.SpawnPosition,  // 위치 복사
            SpawnTimer = 0f,                         // 타이머 초기화
            SpawnInterval = authoring.SpawnInterval, // 간격 복사
            Prefab = GetEntity(authoring.Prefab)     // GameObject를 Entity로 변환
        });
    }
}