using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public GameObject Rocket;
    private float ScreenWidth;

    private void Start()
    {
        ScreenWidth = Screen.width;
    }

    void Update()
    {
        int i = 0;
        while (i < Input.touchCount)
        {
            if(Input.GetTouch(i).position.x > ScreenWidth / 2 && Input.GetTouch(i).phase == TouchPhase.Began)
            {
                Instantiate(Rocket, this.transform.position, Quaternion.identity);                
            }
            ++i;
        }
    }
}
