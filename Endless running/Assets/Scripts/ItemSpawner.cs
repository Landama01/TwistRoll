using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    public GameObject collectablePrefab;
    public Transform player;

    private float timer = 0f;
    public int SpawnDistance = 50;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 2 && GlobalVariables.Running)
        {
            SpawnCollectable();            
            timer = 0;
        }
    }

    //Actualitzar per instanciar les monedes, no els enemics
    void SpawnCollectable()
    {
        GameObject newECollectable = Instantiate(collectablePrefab, transform);
        newECollectable.transform.localPosition = new Vector3(0, 2.15f, player.position.z + SpawnDistance);        
    }
}
