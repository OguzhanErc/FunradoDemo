using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;

public class EnemyCollusion : MonoBehaviour
{
    FieldOfView fieldOfView;
    public PlayerLevelSystem playerLevelSystem;
    [SerializeField]
    float attackRange;
   
    Animator anim;
    Rigidbody rigidBody;

    //[Serializable]
    //public class Collisions : UnityEvent { }
    //public Collisions Movement;
    //public Collisions Attack;

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
            visibleTarget.GetComponent<PlayerLevelSystem>().currentLevel=0;
            anim.SetTrigger("EnemyAttack");
            Debug.Log("Calisti");
        }
    }

}