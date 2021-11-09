using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class ParallaxBackground : MonoBehaviour
{
    private Vector3Int length;
    private float startPos;

    public GameObject cam;
    public float parallaxSpeed;

    void Start()
    {
        startPos = transform.position.x;
        length = GetComponent<Tilemap>().size;
        Debug.Log(length);
    }

    // Update is called once per frame
    void Update()
    {
        float temp = (cam.transform.position.x * 1 - parallaxSpeed);
        float dist = (cam.transform.position.x * parallaxSpeed);
        transform.position = new Vector3(startPos + dist, transform.position.y, transform.position.z);
        if(temp > startPos + length.x)
        {
            startPos += length.x;
        }
        else if(temp < startPos - length.x)
        {
            startPos -= length.x;
        }
    }
}
