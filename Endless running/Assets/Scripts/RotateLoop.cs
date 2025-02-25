using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateLoop : MonoBehaviour
{
    public float RotationSpeed;
    public float smoothRotationSpeed = 5f;

    private bool isDragging = false;
    private float lastMouseX;
    private float deltaX;

    private float rotationAngleP = 36;
    private float rotationAngleN = -36;

    private bool isRotating = false;
    
    void Update()
    {
        transform.Rotate(0, 0, RotationSpeed * Time.deltaTime);

        if (Input.GetMouseButtonDown(0))
        {
            isDragging = true;
            lastMouseX = Input.mousePosition.x;
        }

        if (Input.GetMouseButtonUp(0))
        {
            isDragging = false;
            if (deltaX > 0)
            {
                StartCoroutine(RotateSmoothly(rotationAngleP));
            }
            else if (deltaX < 0)
            {
                StartCoroutine(RotateSmoothly(rotationAngleN));
            }
        }

        if (isDragging)
        {
            deltaX = Input.mousePosition.x - lastMouseX;
        }
        
        
    }

    IEnumerator RotateSmoothly(float angle)
    {
        isRotating = true; 

        Quaternion startRotation = transform.rotation;
        Quaternion targetRotation = startRotation * Quaternion.Euler(0f, 0f, angle);

        float elapsedTime = 0f;

        while (elapsedTime < 1f)
        {
            transform.rotation = Quaternion.Slerp(startRotation, targetRotation, elapsedTime);
            elapsedTime += Time.deltaTime * smoothRotationSpeed;
            yield return null;
        }

        transform.rotation = targetRotation; 
        isRotating = false; 
    }
}
