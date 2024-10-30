using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{   public GameObject[] Obstacles;
    public float SpawnRate = 3.0f;
    private float timer = 0f;
    public Transform SpawnPoint;
    void Start()
    {
        
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= SpawnRate){
            SpawnObstacle();
            timer = 0f;
        }
    }
    void SpawnObstacle(){
        int Rand = Random.Range(0, Obstacles.Length);
        Instantiate(Obstacles[Rand],SpawnPoint.position,SpawnPoint.rotation);
    }

}
