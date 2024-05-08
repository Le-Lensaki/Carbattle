using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDamageSender : DamageSender
{



    private void Awake()
    {
       
    }


    protected override void ColliderSendDamge(Collider2D collision,string nameSender)
    {
        base.ColliderSendDamge(collision,"Bullet");
        
        

    }
}
