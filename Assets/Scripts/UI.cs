using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{   public Score score;
    public TextMeshProUGUI scorePoints;
    void Start()
    {   
        scorePoints.text= "0";
    }

    void Update()
    {   
        int actualScore=score.ActualScore();
        string scorePointsTXT = actualScore.ToString();
        scorePoints.text = scorePointsTXT;
    }
       public void ReloadScene()
    {
        string actualScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(actualScene);
        Time.timeScale = 1;       
    }
}
