﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static int gameScore = 0;
    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = gameScore.ToString();
    }
}
