using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDameReceiver : DamageReceiver, IHpBarInterface
{
    protected PlayerController playercontroller;

    private void Awake()
    {
        this.playercontroller = GetComponent<PlayerController>();
        this.hp = 5;
    }
    public override void Receive(int damage)
    {
        base.Receive(damage);
        if (this.IsDead())
        {
            this.playercontroller.status.Dead();
            GameManager.instance.GameOver();
        }
    }

    public int HP()
    {
        return this.hp;
    }
}
