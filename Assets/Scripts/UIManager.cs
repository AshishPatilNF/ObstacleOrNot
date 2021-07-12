using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI text;

    public void ScoreUpdate(int score)
    {
        text.text = "" + score;
    }
}
