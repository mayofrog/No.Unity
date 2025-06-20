using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    void Awake() //���� ������Ʈ ������ ��, ���� ����
    {
        Debug.Log("�÷��̾� �����Ͱ� �غ�Ǿ����ϴ�.");
    }

    void OnEnable()
    {
        Debug.Log("�÷��̾ �α����߽��ϴ�.");
    }

    void Start() //������Ʈ ���� ����, ���� ����
    {
        Debug.Log("��� ��� ì����ϴ�.");
    }

    void FixedUpdate() //���� ���� ������Ʈ
    {
        Debug.Log("�̵�~");
    }
    
    void Update() //���� ���� ������Ʈ
    {
        Debug.Log("���� ���!");
    }

    void LateUpdate() //��� ������Ʈ ���� ��
    {
        Debug.Log("����ġ ȹ��.");
    }

    void OnDisable() //���� ������Ʈ�� ��Ȱ��ȭ �Ǿ��� ��
    {
        Debug.Log("�÷��̾ �α׾ƿ��߽��ϴ�.");
    }

    void OnDestroy() //���� ������Ʈ�� ���� �ɶ�
    {
        Debug.Log("�÷��̾� �����͸� �����Ͽ����ϴ�.");
    }

    
}



