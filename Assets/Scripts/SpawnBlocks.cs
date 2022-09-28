using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBlocks : MonoBehaviour
{
    public GameObject blockWallSpawn;
    public Transform spawnPosition;
    public float x = 0;
    public float distanceBetweenBlocks = 10f;
    public int blockWallsQuantity = 0;
    public int blockWallsEnough = 10;


    void Start()
    {
        do
        {
            ++blockWallsQuantity;
            x -= distanceBetweenBlocks;
            spawnPosition.position = new Vector3(x, 0, 0);
            Instantiate(blockWallSpawn, spawnPosition.position, spawnPosition.rotation); 
        }
        while (blockWallsQuantity != blockWallsEnough);
    }
}
