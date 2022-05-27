using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class glassScore : MonoBehaviour
{
    public GameObject shatteredObject;



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("destructive"))
        {
            GameControll.instance.glassBroken.Play();
            GameControll.instance.ballsCount += 3;
            GameControll.instance.text_score.text = "" + GameControll.instance.ballsCount;
            //picks a random gameobject in the array
            //int objectIndex = Random.RandomRange(0, shatteredObject.Length);
            Instantiate(shatteredObject, transform.position, shatteredObject.transform.rotation);
            Destroy(gameObject);
        }
    }
}
