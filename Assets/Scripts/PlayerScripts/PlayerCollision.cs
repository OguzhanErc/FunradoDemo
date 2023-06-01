using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerCollision : MonoBehaviour
{
    Animator anim;
    bool isPlayerDead;

    [Serializable] public class Events : UnityEvent { }

    public Events Kill;
    public Events Die;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (GameManager.instance.enemyLevelHigher)
        {
            Die.Invoke();
        }
        if (GameManager.instance.playerLevelHigher)
        {
            Kill.Invoke();
        }
    }

    public void KillEnemy()
    {
        anim.SetTrigger("Attack");
        GameManager.instance.isEnemyDead = true;
    }

    public void Dead()
    {
        anim.SetTrigger("Attack");
        anim.SetTrigger("Death");
        Destroy(gameObject, 3f);
        Debug.Log("Player is dead");
        GameManager.instance.isPlayerDead = true;
       
    }

}
