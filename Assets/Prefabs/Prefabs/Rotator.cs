using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float speed = 1f;

    public bool vertical = false;

    void Update()
    {
        if (vertical)
        {
            transform.Rotate(speed * Time.deltaTime / 0.01f, 0f, 0f, Space.Self);
        }
        else
        {
            transform.Rotate(0f, 0f, speed * Time.deltaTime / 0.01f, Space.Self);
        }
    }
}
