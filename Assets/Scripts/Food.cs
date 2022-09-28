using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) 
        {
            other.GetComponent<TailSpawn>().AddTail();
            FindObjectOfType<AudioManager>().Play("Pickup Soft");
            Destroy(gameObject);
        }
    }
}
