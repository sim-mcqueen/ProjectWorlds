using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GifAnimator : MonoBehaviour
{
    public Sprite[] idleFrames;
    public Sprite[] deathFrames;

    private int i = 0;

    private void FixedUpdate()
    {
        GetComponent<SpriteRenderer>().sprite = idleFrames[i];
        i++;
        if(i < idleFrames.Length)
        {
            i = 0;
        }
    }


}
