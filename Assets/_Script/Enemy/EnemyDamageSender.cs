using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamageSender : DamageSender
{
    [Header("Enemy")]
    protected EnemyController enemyController;

    private void Awake()
    {
        enemyController = GetComponent<EnemyController>();
    }


    protected override void ColliderSendDamge(Collider2D collision,string name)
    {
        //base.ColliderSendDamge(collision,"Enemy");

        //this.enemyController.damageReceiver.Receive(1);
        
    }


}
