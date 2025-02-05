using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickAndRotate : MonoBehaviour
{
    public float sensitivity = 100.0f;
    public GetRotation _getRotation;

    private void Start()
    {
        _getRotation.GetXRotation(90.0f);
    }
    // Update is called once per frame
    void Update()
    {
        float XMovement = Input.GetAxis("Mouse X");

        float XRotation = XMovement * sensitivity * Time.deltaTime;

        if(_getRotation != null)
        {
            _getRotation.GetXRotation(XRotation);
        }
    }
}
