using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Transform player;

    private float timer = 0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= 1)
        {
            int spawnChance = Random.Range(0,2);
            if(spawnChance == 0)
            {
                SpawnEnemy();
            }
            timer = 0;
        }
    }

    void SpawnEnemy()
    {
        int randomDistance = Random.Range(4, 10) * 5;
        int randomRotation = Random.Range(4, 10) * 5;
        GameObject newEnemy = Instantiate(enemyPrefab, transform);
        newEnemy.transform.localPosition = new Vector3(0, 0, player.position.z + randomDistance);
        newEnemy.transform.rotation = Quaternion.Euler(0, 0, randomRotation);
    }
}
