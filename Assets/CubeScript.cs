using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{

    public static float div = 20f;

    private float maxOffset = 5.5f;

    // Update is called once per frame
    void Update()
    {
        // float noise = Mathf.PerlinNoise(transform.position.x, transform.position.y);
        // var variation = Mathf.Sin(Time.time) + 1f;
        // Vector3 temp = new Vector3(1f, variation * offset, 1f);
        // transform.position = temp;

        float perlin = Mathf.PerlinNoise(transform.position.x / CubeScript.div + Time.time, transform.position.z / CubeScript.div + Time.time);
        transform.localScale = new Vector3(1f, perlin * maxOffset, 1f);
    }
}
