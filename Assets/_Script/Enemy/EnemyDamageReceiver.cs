using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamageReceiver : DamageReceiver,IHpBarInterface
{
    [Header("Enemy")]
    public EnemyController enemyController;

    private void Awake()
    {
        this.enemyController = GetComponent<EnemyController>();

    }

    private void Reset()
    {
        this.hp = 3;
    }

    public override void Receive(int damage)
    {
        base.Receive(damage);
        if (this.IsDead())
        {
            EffectManager.instance.SpawnVFX("Explosion_A", transform.position, transform.rotation);
            this.enemyController.despawner.Despawn();
            AudioManager.instance.PlaySFX("EnemyDestroy");
            UIManager.instance.scoreUpdate();
        }

    }

    public int HP()
    {
        return this.hp;
    }
}
