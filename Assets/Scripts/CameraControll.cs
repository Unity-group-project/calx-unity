using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControll : MonoBehaviour
{
    void Update()
    {
        transform.position = new Vector3(transform.position.x + Time.deltaTime * GameControll.instance.speedCamera, transform.position.y, transform.position.z);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("dammage"))
        {
            GameControll.instance.ballsCount -= 10;
            GameControll.instance.text_score.text = "" + GameControll.instance.ballsCount;
            GameControll.instance.audio_dammage.Play();
        }
    }
}
