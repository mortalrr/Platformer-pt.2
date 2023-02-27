using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UITimer : MonoBehaviour
{
    float time = 0f;
    float startingTime = 300f;
    
    public TextMeshProUGUI timerText;

    private void Start()
    {
        time = startingTime;
    }

    // Update is called once per frame
    void Update()
    {

        time -= 1 * Time.deltaTime;
        timerText.text = $"Time \n{time.ToString("0")}";
        if (time <= 0)
        {
            time = 0;
        }

        if (time <= 100f)
        {
            Debug.Log("Time's up! Failed!");
        }
        
    }
}
