using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingObject : MonoBehaviour
{
    [SerializeField]
    float elapseTime = 3f;

    Rigidbody rigidBody;

    MeshRenderer render;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        render = GetComponent<MeshRenderer>();
        rigidBody.useGravity = false;
        render.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > elapseTime)
        {
            render.enabled = true;
            rigidBody.useGravity = true;
        }
    }
}
