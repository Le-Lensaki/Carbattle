using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombDamageReceiver : DamageReceiver
{

    private void Reset()
    {
        this.hp = 1;
    }

    public override void Receive(int damage)
    {
        base.Receive(damage);
        if (this.IsDead())
        {
            Destroy(gameObject);
            EffectManager.instance.SpawnVFX("Explosion_B",transform.position,transform.rotation);
        }

    }
}
