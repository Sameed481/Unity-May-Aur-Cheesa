using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotator : MonoBehaviour
{
    public float rotatespeed=5;
    private void FixedUpdate()
    {
        transform.Rotate(0, 0, rotatespeed);
    }
}
