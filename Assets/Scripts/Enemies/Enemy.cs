using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [Range(0, 50)]
    public float speed = 30.0f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-speed, 0);
    }

    void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }

    void Update()
    {

    }
}
