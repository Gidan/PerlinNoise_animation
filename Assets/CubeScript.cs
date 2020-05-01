using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{

    public static float div = 20f;

    private float maxOffset = 5.5f;

    void Update()
    {
        float perlin = Mathf.PerlinNoise(transform.position.x / CubeScript.div + Time.time, transform.position.z / CubeScript.div + Time.time);
        transform.localScale = new Vector3(1f, perlin * maxOffset, 1f);
    }
}
