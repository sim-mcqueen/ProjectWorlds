using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MenuTime : MonoBehaviour
{
    private float time;
    private TextMeshProUGUI timerText;
    // Start is called before the first frame update
    void Start()
    {
        timerText = GetComponent<TextMeshProUGUI>();
        time = FindObjectOfType<GameManager>().getTimePassed();
        if(time == 0f)
        {
            gameObject.SetActive(false);
        }
        string minutes = ((int)time / 60).ToString();
        string seconds = (time % 60).ToString("f1");

        timerText.text = "Time: " + minutes + ":" + seconds;
    }

    
}
