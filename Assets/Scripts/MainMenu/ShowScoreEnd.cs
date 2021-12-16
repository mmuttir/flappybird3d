using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowScoreEnd : MonoBehaviour
{
    public TMP_Text gs;
    // Start is called before the first frame update
    void Start()
    {
        gs.text = "Score: " + ScoreManager.gameScore;
        ScoreManager.gameScore = 0;
    }
}
