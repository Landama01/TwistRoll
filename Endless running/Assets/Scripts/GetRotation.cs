using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetRotation : MonoBehaviour
{
    public bool Collectable = false;

    public GameObject Click_Drag;
    private float RecivedRotationX;
    
    int randomRotation = 0;

    void Start()
    {
        Click_Drag = GameObject.Find("ClickDrag");

        transform.rotation = Click_Drag.transform.rotation;

        if(Collectable){
            randomRotation = Random.Range(0, 10) * 36;
        }
    }

    private void Update()
    {
        if (!Collectable)
        {
            transform.rotation = Click_Drag.transform.rotation;

        }
        else if (Collectable)
        {
            CollectableRotation(Click_Drag);
        }
    }

    void CollectableRotation(GameObject ClickDrag)
    {        
        transform.rotation = Quaternion.Euler(ClickDrag.transform.rotation.eulerAngles.x + randomRotation, 90, 90);
    }
}
