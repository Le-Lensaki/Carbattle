using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotPlayer : MonoBehaviour
{
    public Transform player;
    protected float speed = 35f;
    protected float dislimit = 0f;
    public float randPos = 0;


    private void Start()
    {

        this.player = PlayerController.instance.transform;
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        this.Shot();
        this.isDespawner();
    }

    void Shot()
    {


        GameObject obj = GameObject.Find("BulletDespawnPos");
        Vector3 pos = new Vector3(gameObject.transform.position.x, obj.transform.position.y,0); 
        transform.position = Vector3.MoveTowards(gameObject.transform.position, pos, speed * Time.deltaTime);

        
    }
    void isDespawner()
    {
        GameObject obj = GameObject.Find("BulletDespawnPos");
        if (transform.position.y == obj.transform.position.y) Destroy(gameObject);
    }
}
