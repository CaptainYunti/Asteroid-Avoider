using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreSystem : MonoBehaviour
{
    [SerializeField] float scoreMultiplier = 1f;
    [SerializeField] TMP_Text scoreText;

    float score;
    bool shouldCount = true;


    // Update is called once per frame
    void Update()
    {
        if(!shouldCount) { return; }

        score += scoreMultiplier * Time.deltaTime;
        scoreText.text = Mathf.FloorToInt(score).ToString();
    }

    public int EndTimer()
    {
        shouldCount = false;

        scoreText.text = string.Empty;

        return Mathf.FloorToInt(score);
    }

    public void StartTimer()
    {
        shouldCount = true;
    }
}
