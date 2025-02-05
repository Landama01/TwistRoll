using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetRotation : MonoBehaviour
{
    private float RecivedRotation;

    void Start()
    {
        transform.rotation = Quaternion.Euler(RecivedRotation, 0, 0);
    }

    public void GetXRotation(float XRotation)
    {
        RecivedRotation = XRotation;
    }

    // Start is called before the first frame update
    

    private void Update()
    {
        transform.rotation = Quaternion.Euler(RecivedRotation, 0, 0);
    }

}
