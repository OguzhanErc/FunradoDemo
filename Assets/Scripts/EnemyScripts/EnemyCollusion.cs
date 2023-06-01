using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;

public class EnemyCollusion : MonoBehaviour
{
    FieldOfView fieldOfView;
    
    [SerializeField]
    float attackRange;

    Transform target;
    public bool enemyDies;
    public bool playerDies;

    Animator anim;
    Rigidbody rigidBody;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
        fieldOfView = GetComponent<FieldOfView>();
    }

    void Update()
    {

        TargetPlayer();
    }

    void TargetPlayer()
    {
        foreach (Transform visibleTarget in fieldOfView.visibleTargets)
        {
            if (GameManager.instance.playerLevelHigher)
            {
                anim.SetTrigger("EnemyAttack");
                target = fieldOfView.visibleTargets[0];
                anim.SetBool("Movement", false);
                anim.SetTrigger("Death");
                Destroy(gameObject, 3f);
                GetComponent<EnemyMovement>().isEnemyStopped = true;
                GameManager.instance.playerLevelHigher = false;
            }
            if (GameManager.instance.enemyLevelHigher)
            {
                anim.SetTrigger("EnemyAttack");
                anim.SetBool("Movement",true);
                GameManager.instance.enemyLevelHigher = false;
            }          
        }
    }
}
