using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstacle;

    private float spawnTime;
    public float startTime;


    private void Update()
    {   
        if (spawnTime <= 0)
        {

            Instantiate(obstacle, transform.position, Quaternion.identity);
            spawnTime = startTime;

        }else
        {
            spawnTime -= Time.deltaTime;
        }



    }

}
