using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public EnemyController[] enemiesToSpawn;                //���� ���� �迭 ��

    public Transform spawnPoint;

    public float timeBetweenSpawn = 0.5f;                   //���� ���� �ð�
    private float spawnCounter;                             //���ڸ� ī���� �ϴ� ����

    public int amoutToSpawn = 15;                           //������ �� ���� ����
    // Start is called before the first frame update
    void Start()
    {
        spawnCounter = timeBetweenSpawn;
    }

    // Update is called once per frame
    void Update()
    {
        if(amoutToSpawn > 0)                            //�����ִ� ������ ���ڰ� ���� ��
        {
            spawnCounter -= Time.deltaTime;             //������ ���� �ð��� ���� ��Ŵ
            if(spawnCounter <= 0)                       //spawnCount 0������ ��
            {
                spawnCounter = timeBetweenSpawn;        //������ ���� ���� ���� �ð��� �ٽ� ����

                //�迭���� ������ ���ؼ� �������� ����, ��ġ�� �����̼� ��
                Instantiate(enemiesToSpawn[Random.Range(0, enemiesToSpawn.Length)], spawnPoint.position, spawnPoint.rotation);

                amoutToSpawn--;                         //������ ���ڸ� ���ش�
            }
        }
    }
}
