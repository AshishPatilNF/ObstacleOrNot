using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesObject : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Player>())
        {
            GetComponent<MeshRenderer>().material.color = Color.yellow;
            collision.gameObject.GetComponent<Player>().AddScore();
        }
    }
}
