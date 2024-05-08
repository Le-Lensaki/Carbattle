using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    protected float speed = 27f;
    protected float dislimit = 3f;
    public float randPos = 0;


    private void Awake()
    {

        this.player = PlayerController.instance.transform;
        this.randPos = Random.Range(-6,6);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        this.Follow();
    }

    void Follow()
    {
        Vector3 pos = this.player.position;
        pos.x = this.randPos;

        Vector3 distance = pos - transform.position;
        if(distance.magnitude >= this.dislimit )
        {
            Vector3 targetPoint = pos - distance.normalized * this.dislimit;
            transform.position = Vector3.MoveTowards(gameObject.transform.position, targetPoint, speed * Time.deltaTime);

        }
    }
}
