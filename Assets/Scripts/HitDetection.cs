using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HitDetection : MonoBehaviour
{

    public GameObject Rocket;
    public GameObject Player;

    public Score score;

    static public float passScore;

    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.tag);
        Debug.Log(Player.tag);
        if(other.tag == Rocket.tag)
        {
            Destroy(this.gameObject);
            Destroy(other.gameObject);
        } else if (other.tag == Player.tag)
        {
            //Game over
            Destroy(this.gameObject);
            Destroy(other.gameObject);
            Debug.Log("GAME OVER");
            Score.stopScoreCount();
            passScore = Score.saveScore;
            SceneManager.LoadScene("GameOverScene");
        }
    }

    void Update()
    {

    }
}
