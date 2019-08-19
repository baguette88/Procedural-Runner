using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    private float timeTillDestroy = 10.0f;


   
    // Update is called once per frame
    void Update()
    {
        timeTillDestroy -= Time.deltaTime;
        if (timeTillDestroy < .01 && Gameinit.gameIsPlaying == true)
        {
            Destroy(gameObject);
        }
    }
}
