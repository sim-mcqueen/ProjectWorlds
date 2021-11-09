using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static float timePassed;

    public void saveTime(float time)
    {
        timePassed += time;
    }

    public void resetTime()
    {
        timePassed = 0f;
    }

    public float getTimePassed()
    {
        return timePassed;
    }
}
