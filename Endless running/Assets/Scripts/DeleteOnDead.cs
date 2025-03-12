using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteOnDead : MonoBehaviour
{
    void Update()
    {
        if (GlobalVariables.playerDead)
        {
            Destroy(gameObject);
        }
    }
}
