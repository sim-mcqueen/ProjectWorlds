using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerScript : MonoBehaviour
{
    private TextMeshProUGUI timerText;
    private float startTime;

    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
        timerText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        float t = Time.time - startTime;

        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f1");

        timerText.text = minutes + ":" + seconds;

    }


    public void timeStop()
    {
        FindObjectOfType<GameManager>().saveTime(Time.time - startTime);
    }
}
