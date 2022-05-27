using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class glassShatter : MonoBehaviour
{
    public GameObject shatteredObject;



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("destructive"))
        {
            GameControll.instance.glassBroken.Play();
            //picks a random gameobject in the array
            //int objectIndex = Random.RandomRange(0, shatteredObject.Length);
            Instantiate(shatteredObject, transform.position, shatteredObject.transform.rotation);
            Destroy(gameObject);
        }
    }
}
