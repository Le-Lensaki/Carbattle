using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : Spawner
{
    private void Reset()
    {
        this.spawnPosName = "EnemySpawner";
        this.prefabName = "BulletPrefab";
        this.maxObj = 10;
        this.spawnDelay = 2f;
        this.isBullet = true;
    }

    
}
