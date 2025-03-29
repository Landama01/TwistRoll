using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Instantiator : MonoBehaviour
{
    public GameObject platformPrefab;
    public GameObject platformPrefab2;
    public GameObject platformPrefab3;

    public int StartPlatforms = 5;

    public float separation = 10.0f;
    private Vector3 Position;
    private Quaternion Rotation = Quaternion.Euler(18, 90, 90);

    int randomNum;

    // Start is called before the first frame update
    void Start()
    {
        Position.y = 2.15f;
        for (int i = 1; i <= StartPlatforms; i++)
        {
            if (!GlobalVariables.Running)
            {
                randomNum = 0;
            }
            else if (GlobalVariables.Running)
            {
                randomNum = Random.Range(0, 2);
            }
            
            switch(randomNum)
            {
                case 0:
                    Position.z += separation;
                    Instantiate(platformPrefab, Position, Rotation);
                    break;
                case 1:
                    Position.z += separation;
                    Instantiate(platformPrefab2, Position, Rotation);
                    break;
                case 2:
                    Position.z += separation;
                    Instantiate(platformPrefab3, Position, Rotation);
                    break;


            }                       
        }
    }

    void Update()
    {
        if (GlobalVariables.playerDead)
        {
            Position.z = 50;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Platform"))
        {
            if (!GlobalVariables.Running)
            {
                randomNum = 0;
            }
            else if (GlobalVariables.Running)
            {
                randomNum = Random.Range(1, 2);
            }
            switch (randomNum)
            {
                case 0:
                    Position.z += separation;
                    Instantiate(platformPrefab, Position, Rotation);
                    break;
                case 1:
                    Position.z += separation;
                    Instantiate(platformPrefab2, Position, Rotation);
                    break;
                case 2:
                    Position.z += separation;
                    Instantiate(platformPrefab2, Position, Rotation);
                    break;


            }
        }
    }
}