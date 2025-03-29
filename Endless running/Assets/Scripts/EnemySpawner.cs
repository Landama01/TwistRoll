using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Transform player;

    private float timer = 0f;
    public int MaxSpawnRange = 10;

    bool ScoreCheck = false;

    // Update is called once per frame
    void Update()
    {
        Debug.Log(MaxSpawnRange);
        if (GlobalVariables.Score % 20 == 0 && MaxSpawnRange >= 3) 
        {
            if (!ScoreCheck)
            {
                MaxSpawnRange--;
                ScoreCheck = true;
            }    
        }
        else
        {
            ScoreCheck = false;
        }

        timer += Time.deltaTime;
        if(timer >= 2 && GlobalVariables.Running)
        {
            int spawnChance = Random.Range(0,MaxSpawnRange);
            if(spawnChance == 0)
            {
                SpawnEnemy();
            }
            timer = 0;
        }
    }

    void SpawnEnemy()
    {
        int randomDistance = Random.Range(8, 16) * 5;
        int randomRotation = Random.Range(4, 10) * 5;
        GameObject newEnemy = Instantiate(enemyPrefab, transform);
        newEnemy.transform.localPosition = new Vector3(0, 0, player.position.z + randomDistance);
        newEnemy.transform.rotation = Quaternion.Euler(0, 0, randomRotation);
    }
}
