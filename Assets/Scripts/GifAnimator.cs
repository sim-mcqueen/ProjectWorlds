/////////////////////////////////////////////////
//// Name: Sim McQueen
//// Date: 11/2/21
//// Proj: ProjectWorlds
//// Desc: Once given some frames of an Animation, it will cycle through those frames based on the delay
/////////////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GifAnimator : MonoBehaviour
{
    public Sprite[] idleFrames;
    public Sprite[] deathFrames;
    public float Delay;

    private int i = 0;

    private void Start()
    {
        i = Random.Range(0, 3);
        StartCoroutine(Animate());
    }

    IEnumerator Animate()
    {
        GetComponent<SpriteRenderer>().sprite = idleFrames[i];
        i++;
        if (i > idleFrames.Length - 1)
        {
            i = 0;
        }

        yield return new WaitForSeconds(Delay);
        StartCoroutine(Animate());
    }


}
