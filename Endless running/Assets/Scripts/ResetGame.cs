using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ResetGame : MonoBehaviour
{
    private int resetCont = 0;

    public GameObject player;

    public GameObject platformPrefab;
    public GameObject platformPrefab2;
    public GameObject platformPrefab3;

    public int StartPlatforms = 5;

    public float separation = 10.0f;
    private Vector3 Position;
    private Quaternion Rotation = Quaternion.Euler(18, 90, 90);

    int randomNum;

    // Update is called once per frame
    void Update()
    {
        if (GlobalVariables.playerDead)
        {
            resetCont++;            
        }

        switch(resetCont)
        {
            case 1:
                player.transform.position = new Vector3(0f, -0.36f, 0f);

                Position.y = 2.15f;
                Position.z = 0f;

                Instantiate(platformPrefab, Position, Rotation);

                for (int i = 1; i <= StartPlatforms; i++)
                {
                    randomNum = Random.Range(0, 3);
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
                            Instantiate(platformPrefab3, Position, Rotation);
                            break;


                    }
                }
                break;
            case 2:
                GlobalVariables.playerDead = false;
                resetCont = 0;
                break;

        }

    }
}
