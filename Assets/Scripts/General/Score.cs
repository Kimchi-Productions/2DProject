using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public Text scoreText;
    static public float scoreAmount;
    public float counter;
    static public float saveScore;

    public HitDetection hitDetection;

    public float tutorialLength = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        scoreAmount = 0f;
        counter = 20f;
    }

    // Update is called once per frame
    void Update()
    {
        tutorialLength -= Time.deltaTime;

        if(tutorialLength < 0){
            scoreText.text = "Score: " + (int)scoreAmount;
            scoreAmount += counter * Time.deltaTime;
        }
    }

    static public void stopScoreCount(){
        saveScore = scoreAmount;
        Debug.Log("Your score is: " + (int)saveScore);
    }

}
