using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    void Awake() //게임 오브젝트 생성할 때, 최초 실행
    {
        Debug.Log("플레이어 데이터가 준비되었습니다.");
    }

    void OnEnable()
    {
        Debug.Log("플레이어가 로그인했습니다.");
    }

    void Start() //업데이트 시작 직전, 최초 실행
    {
        Debug.Log("사냥 장비를 챙겼습니다.");
    }

    void FixedUpdate() //물리 연산 업데이트
    {
        Debug.Log("이동~");
    }
    
    void Update() //게임 로직 업데이트
    {
        Debug.Log("몬스터 사냥!");
    }

    void LateUpdate() //모든 업데이트 끝난 후
    {
        Debug.Log("경험치 획득.");
    }

    void OnDisable() //게임 오브젝트가 비활성화 되었을 때
    {
        Debug.Log("플레이어가 로그아웃했습니다.");
    }

    void OnDestroy() //게임 오브젝트가 삭제 될때
    {
        Debug.Log("플레이어 데이터를 해제하였습니다.");
    }

    
}



