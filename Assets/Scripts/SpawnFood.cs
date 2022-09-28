using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFood : MonoBehaviour
{
    public GameObject FoodPrefab;
    public Transform spawnPosition;
    public float x = 0;
    public Vector3 StartX;
    public Vector3 FinishX;
    public Vector3 LeftZ;
    public Vector3 RightZ;
    public float z = 0;
    public int FoodQuantity = 0;
    public int FoodQuantityEnough = 30;


    void Start()
    {
        do
        {
            ++FoodQuantity;
            x = Random.Range(StartX.x, FinishX.x);
            z = Random.Range(LeftZ.z, RightZ.z);
            spawnPosition.position = new Vector3(x, 1f, z);
            Instantiate(FoodPrefab, spawnPosition.position, spawnPosition.rotation);
        }
        while (FoodQuantity != FoodQuantityEnough);
    }

}
