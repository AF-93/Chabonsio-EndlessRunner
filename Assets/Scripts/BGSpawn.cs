using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGSpawn : MonoBehaviour
{
    public GameObject[] BG_Objects;
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
            SpawnBGO();
            timer = 0f;
        }
    }
    void    SpawnBGO(){
        int RandBG = Random.Range(0, BG_Objects.Length);
        Instantiate(BG_Objects[RandBG],SpawnPoint.position,SpawnPoint.rotation);
    }


}
