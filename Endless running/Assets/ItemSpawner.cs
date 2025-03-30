using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    public GameObject collectablePrefab;
    public Transform player;

    private float timer = 0f;
    public int SpawnDistance = 10;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 2 && GlobalVariables.Running)
        {
            int spawnChance = Random.Range(0, SpawnDistance);
            if (spawnChance == 0)
            {
                SpawnEnemy();
            }
            timer = 0;
        }
    }

    //Actualitzar per instanciar les monedes, no els enemics
    void SpawnEnemy()
    {
        int randomDistance = Random.Range(8, 16) * 5;
        int randomRotation = Random.Range(4, 10) * 5;
        GameObject newEnemy = Instantiate(collectablePrefab, transform);
        newEnemy.transform.localPosition = new Vector3(0, 0, player.position.z + randomDistance);
        newEnemy.transform.rotation = Quaternion.Euler(0, 0, randomRotation);
    }
}
