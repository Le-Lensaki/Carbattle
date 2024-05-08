using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{

    protected PlayerController controller;

    private void Awake()
    {
        this.controller = GetComponent<PlayerController>();
    }

    public virtual void Dead()
    {
        Debug.Log("Dead");
    }
}
