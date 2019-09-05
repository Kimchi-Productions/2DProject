using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    private Vector2 screenBounds;
    public GameObject EnemyPrefab;

    [Range(0, 5)]
    public float respawnTime = 0;
    public float difficultyIncrease = 0;
    public float enemySpawnOffset = 0;
    public float tutorialLength = 5.0f;
    public int counter = 0;
    public bool enemyWaveStarted = false;
    public bool increaseDifficultyStarted = false;


    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        
        StartCoroutine(IncreaseDifficulty());
    }

    private void spawnEnemy()
    {
        GameObject a = Instantiate(EnemyPrefab) as GameObject;
        a.transform.position = new Vector2(screenBounds.x, Random.Range(-screenBounds.y + enemySpawnOffset, screenBounds.y - enemySpawnOffset));
    }

    IEnumerator EnemyWave(){
        enemyWaveStarted = true;
        while(true)
        {
          yield return new WaitForSeconds(respawnTime);
          spawnEnemy();   
        }
    }

    IEnumerator IncreaseDifficulty()
    {
        increaseDifficultyStarted = true;
        while (true)
        {
            yield return new WaitForSeconds(1f);
            respawnTime = respawnTime - difficultyIncrease;
        }
    }

    void Update(){

        tutorialLength -= Time.deltaTime;

        if(tutorialLength < 0){
            if(!enemyWaveStarted){
                StartCoroutine(EnemyWave());
            }

            if(!increaseDifficultyStarted){
                StartCoroutine(IncreaseDifficulty());
            }
        }
    }
}
