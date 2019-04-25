using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //敵のCubeオブジェクト
    [SerializeField] private GameObject enemy;
    void Start()
    {
        InstantiateEnemies(10);
    }

    void Update()
    {
        
    }

    //引数の回数だけ敵のブロックを、生成位置をランダムに選んで生成
    private void InstantiateEnemies(int count)
    {
        GameObject[] spawnPoints = GameObject.FindGameObjectsWithTag("Respawn");
        for(int i = 0; i < count; i++)
        {
            Instantiate(enemy, spawnPoints[Random.Range(0, spawnPoints.Length)].transform.position, Quaternion.identity);
        }
    }

}
