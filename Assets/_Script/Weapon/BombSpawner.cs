using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombSpawner : Spawner
{



    private void Reset()
    {
        this.spawnPosName = "BombSpawnPos";
        this.prefabName = "BombPrefab";
        this.maxObj = 4;
        this.spawnDelay = 1;
    }

    // Update is called once per frame
    



    private void NotSpawn()
    {
        Debug.Log("Not Spawn");
    }

    
}
