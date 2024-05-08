using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController instance; 
    public DamageReceiver damageReceiver;
    public PlayerStatus status;
    

    private void Awake()
    {
        PlayerController.instance = this;

        damageReceiver = GetComponent<DamageReceiver>();
        this.status = GetComponent<PlayerStatus>();
       

        
    }
}
