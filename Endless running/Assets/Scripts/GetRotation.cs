using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetRotation : MonoBehaviour
{
    public GameObject Click_Drag;
    private float RecivedRotationX;

    void Start()
    {
        Click_Drag = GameObject.Find("ClickDrag");

        transform.rotation = Click_Drag.transform.rotation;
    }

    private void Update()
    {
        transform.rotation = Click_Drag.transform.rotation;
    }

}
