using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMove : MonoBehaviour
{   public float MoveSpeed = 5.0f;
    public float MapLimit;

    void Update()
    {
        transform.Translate(Vector2.left * MoveSpeed *Time.deltaTime);
        if (transform.position.x < MapLimit){
            Destroy(gameObject);
        }
        }
}
