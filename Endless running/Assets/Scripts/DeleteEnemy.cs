using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteEnemy : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "EnemyPivot")
        {
            Destroy(other.gameObject);
        }
    }
}
