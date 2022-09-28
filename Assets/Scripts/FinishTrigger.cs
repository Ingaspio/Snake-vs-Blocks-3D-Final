using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishTrigger : MonoBehaviour
{
    public Collider coll;
    public GameObject FinishPanel;
    

    private void OnTriggerEnter(Collider coll)
    {
        if (coll.CompareTag("Player"))
        {  
            FinishPanel.SetActive(true);
        }
    }

}
