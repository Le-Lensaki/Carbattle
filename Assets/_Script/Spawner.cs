using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Header("Spawner")]
    public GameObject objPrefab;
    public GameObject spawnPos;
    public List<GameObject> objects;
    public float spawnTimer = 0f;
    public float spawnDelay = 1f;
    public string spawnPosName = "";
    public string prefabName = "";
    public int maxObj = 1;
    public bool isBullet = false;

    private void Awake()
    {
        
        this.objects = new List<GameObject>();
        this.spawnPos = GameObject.Find(this.spawnPosName);
        this.objPrefab = GameObject.Find(this.prefabName);

        

        this.objPrefab.SetActive(false);

        
    }

    private void Update()
    {
        this.Spawn();


        this.CheckDead();
    }

    protected virtual GameObject Spawn()
    {
        if (PlayerController.instance.damageReceiver.IsDead()) return null;
        if (this.objects.Count > this.maxObj) return null;

        this.spawnTimer += Time.deltaTime;
        if (this.spawnTimer < this.spawnDelay) return null;
        this.spawnTimer = 0;

        Vector3 pos = new Vector3();
        if(!isBullet) pos = this.spawnPos.transform.position;
        else if (isBullet && GameObject.Find("EnemyPrefab(Clone)") != null)
        {
            this.spawnPos = GameObject.Find("EnemyPrefab(Clone)");
            pos = this.spawnPos.transform.position;
            AudioManager.instance.PlaySFX("Laser");
            
                
        }
        if(isBullet && GameObject.Find("EnemyPrefab(Clone)") == null) return null;

        pos.z = 0;
        

        return this.Spawn(pos);
    }

    protected virtual GameObject Spawn(Vector3 pos)
    {

        GameObject obj = Instantiate(this.objPrefab);
        obj.transform.position = pos;
        obj.transform.parent = transform;
        obj.SetActive(true);

        this.objects.Add(obj);
        return obj;
    }

    protected virtual void CheckDead()
    {
        GameObject minion;
        for (int i = 0; i < this.objects.Count; i++)
        {
            minion = this.objects[i];
            if (minion == null) this.objects.RemoveAt(i);
        }
    }

}
