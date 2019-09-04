using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    private Vector2 screenBounds;
    public GameObject EnemyPrefab;

    [Range(0, 5)]
    public float respawnTime = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(EnemyWave());
    }

    private void spawnEnemy(){
        GameObject a = Instantiate(EnemyPrefab) as GameObject;
        a.transform.position = new Vector2(screenBounds.x, Random.Range(-screenBounds.y, screenBounds.y));
    }

    IEnumerator EnemyWave(){
        while(true){
          yield return new WaitForSeconds(respawnTime);
          spawnEnemy();   
        }
    }

    // // Update is called once per frame
    // void Update()
    // {

    // }
}
