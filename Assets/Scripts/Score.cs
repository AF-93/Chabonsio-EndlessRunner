using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Score : MonoBehaviour
{   
    public int score;
    void Start(){
        score=0;
    }
    void OnTriggerEnter2D(Collider2D colission){
        if(colission.CompareTag("Obstacle")){
            score+=1;
        }
    }
    public int ActualScore(){
        return score;
    }
}
