using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBall : MonoBehaviour
{
    private Camera _cam;
    void Start()
    {
        _cam = SpawnBall.instance._cam;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.x < _cam.transform.position.x - 5f || gameObject.transform.position.y < -100)   //Repair road
        {
            Destroy(gameObject);
        }
    }
}
