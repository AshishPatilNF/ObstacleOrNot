using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<MeshRenderer>().material.color = Color.yellow;

        if (collision.gameObject.GetComponent<Player>())
            collision.gameObject.GetComponent<Player>().AddScore();
    }
}
