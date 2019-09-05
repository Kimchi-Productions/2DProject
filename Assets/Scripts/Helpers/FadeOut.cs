using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeOut : MonoBehaviour
{

    public float tutorialLength = 5.0f; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tutorialLength -= Time.deltaTime;

        if(tutorialLength < 0f){
            Destroy(this.gameObject);
            Debug.Log("destory");
        }
    }
}
