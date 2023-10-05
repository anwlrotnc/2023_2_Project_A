using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public EnemyController[] enemiesToSpawn;                //몬스터 종류 배열 값

    public Transform spawnPoint;

    public float timeBetweenSpawn = 0.5f;                   //스폰 사이 시간
    private float spawnCounter;                             //숫자를 카운팅 하는 변수

    public int amoutToSpawn = 15;                           //스폰될 때 몬스터 숫자
    // Start is called before the first frame update
    void Start()
    {
        spawnCounter = timeBetweenSpawn;
    }

    // Update is called once per frame
    void Update()
    {
        if(amoutToSpawn > 0)                            //남아있는 스폰될 숫자가 있을 때
        {
            spawnCounter -= Time.deltaTime;             //프레임 마다 시간을 감소 시킴
            if(spawnCounter <= 0)                       //spawnCount 0이하일 때
            {
                spawnCounter = timeBetweenSpawn;        //정해진 스폰 사이 간격 시간을 다시 리셋

                //배열안의 랜덤값 정해서 프리팹을 생성, 위치랑 로테이션 값
                Instantiate(enemiesToSpawn[Random.Range(0, enemiesToSpawn.Length)], spawnPoint.position, spawnPoint.rotation);

                amoutToSpawn--;                         //스폰될 숫자를 빼준다
            }
        }
    }
}
