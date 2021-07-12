using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishGame : MonoBehaviour
{
    LevelLoader levelLoader;

    private void Start()
    {
        levelLoader = FindObjectOfType<LevelLoader>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Player>())
            levelLoader.LoadNextScene();
    }
}
