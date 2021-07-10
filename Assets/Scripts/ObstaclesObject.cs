using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesObject : MonoBehaviour
{
    bool getHit = true;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Player>())
        {
            GetComponent<MeshRenderer>().material.color = Color.red;

            if (getHit)
            {
                collision.gameObject.GetComponent<Player>().AddScore();
                getHit = false;
            }
        }
    }
}
