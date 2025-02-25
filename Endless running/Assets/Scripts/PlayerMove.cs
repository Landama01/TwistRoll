using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 2.0f;
    public float CastDistance = 1.0f;

    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        RaycastHit hit;
        if(Physics.Raycast(transform.position, Vector3.down, out hit, CastDistance))
        {
            rb.useGravity = false;
            rb.velocity = Vector3.zero;
        }
        else
        {
            rb.useGravity = true;
        }
    }
}
