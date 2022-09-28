using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStartPosition : MonoBehaviour
{
    public GameObject HeadPrefab;
    public Transform startPosition;

    void Start()
    {
        
        Instantiate(HeadPrefab, startPosition.position, startPosition.rotation);
    }
   
}
