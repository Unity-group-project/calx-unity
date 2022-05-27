using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public GameObject movingDoor_left;
    public GameObject movingDoor_right;

    public float maximumOpening = 10.5f;

    public float movementSpeed = 3f;

    bool playerIsHere;

    void Start()
    {
        playerIsHere = false;
    }

    void Update()
    {
        if (playerIsHere)
        {
            if (movingDoor_left.transform.position.x < maximumOpening && movingDoor_right.transform.position.x < maximumOpening)
            {
                movingDoor_left.transform.Translate(0f, 0f, movementSpeed * Time.deltaTime);
                movingDoor_right.transform.Translate(0f, 0f, -movementSpeed * Time.deltaTime);
            }
        }
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            playerIsHere = true;
        }
    }
}
