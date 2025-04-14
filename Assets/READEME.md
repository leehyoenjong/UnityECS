# Unity ECS 학습 로드맵

이 문서는 Unity ECS (Entity Component System)를 단계별로 학습하기 위한 로드맵입니다.

## 학습 단계

1.  **ECS 기본 개념 이해 및 환경 설정:**
    *   Entity, Component, System (IComponentData, ISystem, SystemBase) 핵심 개념 학습
    *   프로젝트에 필요한 ECS 관련 패키지 설치 (Entities, Entities Graphics 등) 확인

2.  **기본 컴포넌트 및 시스템 작성:**
    *   간단한 데이터만 가지는 `IComponentData` 정의 (예: `int` 값을 가진 `MyValue` 컴포넌트)
    *   `SystemBase`를 상속받아 특정 컴포넌트를 가진 엔티티를 쿼리하고 데이터를 수정하는 시스템 작성 (예: `MyValue` 값을 증가시키는 시스템)
    *   에디터 또는 코드를 통해 테스트용 엔티티를 생성하고 컴포넌트 추가하여 시스템 동작 확인

3.  **엔티티 생성 및 관리:**
    *   `EntityManager`를 사용하여 코드로 엔티티 생성, 컴포넌트 추가/제거/수정 방법 학습
    *   엔티티 아키타입(Archetype)의 개념과 중요성 이해
    *   엔티티 파괴 방법 학습

4.  **데이터 쿼리 및 처리 (Job 시스템 기초):**
    *   `Entities.ForEach`를 사용하여 엔티티를 효율적으로 쿼리하고 작업 수행
    *   `IJobEntity` (또는 `IJobChunk`)를 활용하여 병렬 처리(Multithreading)를 통한 성능 향상 방법 맛보기

5.  **Aspects 사용:**
    *   관련 컴포넌트들을 논리적으로 그룹화하고 접근을 단순화하는 `IAspect` 정의 방법 학습
    *   시스템 내에서 `Aspect`를 사용하여 컴포넌트 데이터에 접근하고 수정하는 방법 학습

6.  **Baking (GameObject 변환):**
    *   기존 `GameObject` 기반 워크플로우를 ECS와 통합하는 방법 학습
    *   Authoring 컴포넌트 (`MonoBehaviour`)와 `Baker` 클래스를 작성하여 `GameObject`를 엔티티로 변환하는 과정 이해
    *   `Baker` 내에서 엔티티에 컴포넌트를 추가하는 방법 학습

7.  **Rendering (Entities Graphics):**
    *   `Entities Graphics` 패키지를 사용하여 ECS로 엔티티를 렌더링하는 기본 방법 학습
    *   `URPMaterialProperty`, `RenderMesh`, `LocalToWorld` 등 렌더링 관련 필수 컴포넌트 이해
    *   매터리얼과 메쉬를 엔티티에 적용하는 방법 학습

8.  **상태 관리 및 이벤트 처리:**
    *   Enableable Components (`IEnableableComponent`)를 사용하여 엔티티의 상태(활성/비활성 등) 관리 방법 학습
    *   ECS에서 이벤트를 처리하는 일반적인 패턴 학습 (예: `DynamicBuffer<T>`를 이벤트 큐로 활용)

9.  **Physics (Unity Physics / Havok Physics):**
    *   ECS 기반 물리 엔진 (`Unity Physics` 또는 `Havok Physics` - 별도 설치 필요) 연동 기초 학습
    *   물리 관련 컴포넌트(예: `PhysicsVelocity`, `PhysicsCollider`) 및 시스템 이해
    *   간단한 물리 시뮬레이션 구현

10. **고급 주제 (선택 사항):**
    *   `IJobChunk` 심층 학습 (더 세밀한 제어)
    *   시스템 실행 순서 제어 (`UpdateInGroup`, `[UpdateBefore]`, `[UpdateAfter]`)
    *   Sub Scenes를 이용한 대규모 씬 관리 및 스트리밍
    *   DOTS Netcode (ECS 기반 네트워킹 - 별도 패키지 필요)

각 단계를 진행하면서 필요한 개념 설명과 코드 예제를 함께 제공하겠습니다.
