using UnityEngine;

//���� 1�� ������
public class EnemyManager : MonoBehaviour
{
    float currentTime; //���� �ð�
    public float step = 1;//�ð� ����
    public GameObject enemyFactory; //�� ����

    //������Ʈ Ǯ
    [Header("������Ʈ Ǯ")]
    public int poolSize = 10;             
    public GameObject[] pool;
    public Transform[] spawnPoint; //������ ���� ��ġ

    //���� ��� : EnemyManager.cs�� ������ ���� ������ ��ġ�ؼ�
    //            ���� ����

    //�ٲٴ� ��� : EnemyManager�� 1��, ���� ������ ������
    //              �ش� ������ �ð��� ���� Ȱ��ȭ


    //�¾ ���� ���� �۾�
    private void Start()
    {
        pool = new GameObject[poolSize];
        
        for(int i = 0;  i < poolSize; i++)
        {
            var enemy = Instantiate(enemyFactory);
            pool[i] = enemy;
            enemy.SetActive(false);
        }

    }


    private void Update()
    {
        currentTime += Time.deltaTime;

        if(currentTime > step)
        {
            var enemy = Instantiate(enemyFactory);
            enemy.transform.position = transform.position;
            enemy.transform.parent = transform;
            currentTime = 0;
        }
    }
}
