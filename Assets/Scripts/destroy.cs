using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    void Update()
    {
        if (gameObject.transform.position.y < -300f)
            Destroy(gameObject);
    }
}