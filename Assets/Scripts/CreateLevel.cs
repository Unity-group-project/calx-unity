using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateLevel : MonoBehaviour
{
    public List<GameObject> levels = new List<GameObject>();

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("level"))
        {
            //Debug.Log("TRIGGER!");
            int count = Random.Range(0, levels.Count);
            
            Instantiate(levels[count], new Vector3(other.bounds.center.x + other.bounds.size.x / 2 + levels[count].GetComponent<Collider>().bounds.size.x/2 + 20f, 0f, 0f), Quaternion.identity);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("level"))
        {
            Destroy(other.gameObject);
        }
    }
}
