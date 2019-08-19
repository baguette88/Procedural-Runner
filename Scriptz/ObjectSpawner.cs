using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{

    public GameObject player;
    public GameObject[] coins;
    public GameObject[] trees;
    public GameObject enemy;
    private float coinSpawnTimer = 7.0f;
    private float enemySpawnTimer = 10.0f;
    private float treesSpawnTimer = .9f;

    //update is called once per frame
    void Update()
    {
        coinSpawnTimer -= Time.deltaTime;
        enemySpawnTimer -= Time.deltaTime;
        treesSpawnTimer -= Time.deltaTime;
        //       powerupSpawnTimer -= Time.deltaTime;
        // ABOVE at 10//    public GameObject[] powerup;
        // ABOVE at 16//   public GameObject[] powerup;

        if (coinSpawnTimer < .01 && Gameinit.gameIsPlaying == true)
            SpawnCoins();
        //source of non-Renew bug?

        if (enemySpawnTimer < .01 && Gameinit.gameIsPlaying == true)
            SpawnEnemy();

        if (treesSpawnTimer < .01 && Gameinit.gameIsPlaying == true)
            SpawnTrees();

        //       if (powerupSpawnTimer < .01 && Gameinit.gameIsPlaying == true)
        //           SpawnPowerup();


    }

    void SpawnCoins()
    {
        Instantiate(coins[(Random.Range(0, coins.Length))], new Vector3(player.transform.position.x + 30, Random.Range(2, 8), 0), Quaternion.identity);
        //X position is player, y position at 0, Z = Quaternion Identity (current rotation)
        coinSpawnTimer = Random.Range(1.0f, 3.0f);
    }

    void SpawnEnemy()
    {
        //change enemy size (line just below)//REMOVE DEPENDING ON GAME
        enemy.transform.localScale = new Vector3(Random.Range(1, 5), Random.Range(1, 5));
        Instantiate(enemy, new Vector3(player.transform.position.x + 30, Random.Range(1, 9), 0), Quaternion.identity);
        enemySpawnTimer = Random.Range(1, 3);

    }

    void SpawnTrees()
    {
        //change enemy size (line just below)
        Instantiate(trees[(Random.Range(0, trees.Length))], new Vector3(player.transform.position.x + 70, 0, Random.Range(5, 22)), Quaternion.identity);
        //REMOVED EULER from QUATERNION.EULER
        treesSpawnTimer = 0.5f;
    }
}

//Maniopulates enemy size. Comment this out in future games *****
//enemy.transform.localScale = new Vector3(Random.Range(1, 5), Random.Range(1, 5));
//In/stantiate(enemy, new Vector3(player.transform.position.x + 30, Random.Range(1, 9), 0), Quaternion.identity); Quaternion.Euler (Random.Range (3,22)).
//enemySpawnTimer = Random.Range(1, 3);


//  }

//  void SpawnPowerup
// {
//     Instantiate(powerup[(Random.Range(0, powerup.Length))], new Vector3(player.transform.position.x + 30, Random.Range(2, 8), 0), Quaternion.identity);
//COMMENT //X position is player, y position at 0, Z = Quaternion Identity (current rotation)
//     powerupSpawnTimer = Random.Range(5.0f, 7.0f);
//  }

