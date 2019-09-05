using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SavedScore : MonoBehaviour
{
    public Text scoreText;
    public float endScore;
    
    public HitDetection hitDetection;

    // Start is called before the first frame update
    void Start()
    {
        endScore = HitDetection.passScore;
        scoreText.text = "Your score: " + (int)endScore;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
