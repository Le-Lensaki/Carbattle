using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombDamageSender : DamageSender
{



    private void Awake()
    {
       
    }


    protected override void ColliderSendDamge(Collider2D collision,string nameSender)
    {
        base.ColliderSendDamge(collision,"Bomb");
        


    }
}
