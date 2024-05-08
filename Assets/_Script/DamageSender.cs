using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageSender : MonoBehaviour
{
    [Header("DamageSender")]
    public int damage = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        this.ColliderSendDamge(collision, "cham");     
    }

    protected virtual void ColliderSendDamge(Collider2D collision, string nameSender)
    {
        
        DamageReceiver damageReceiver = collision.GetComponent<DamageReceiver>();
        
        if (damageReceiver == null) return;

        if (nameSender == "Bullet" && collision.name == "Player")
        {
            
            damageReceiver.Receive(this.damage);
            this.GetComponent<DamageReceiver>().Receive(this.damage);
            return;
        }

        if (nameSender == "Bomb" && collision.name == "EnemyPrefab(Clone)")
        {
           
            damageReceiver.Receive(this.damage);
            this.GetComponent<DamageReceiver>().Receive(this.damage);
            return;
        }
    }
}
