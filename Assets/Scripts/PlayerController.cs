using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float jetpackForce = 75.0f;
    private Rigidbody2D playerRigidbody;
    private float ScreenWidth;


    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody2D>();
        ScreenWidth = Screen.width;

    }

    void FixedUpdate()
    {
        int i = 0;
        while (i < Input.touchCount)
        {
            if (Input.GetTouch(i).position.x < ScreenWidth / 2)
            {
                playerRigidbody.AddForce(new Vector2(0, jetpackForce));
            }
            ++i;
        }
    }
}
