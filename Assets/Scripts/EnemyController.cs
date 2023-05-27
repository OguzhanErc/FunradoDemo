using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public GameStates State;


    public static event Action<GameStates> OnGameStateChanged;


    private void Start()
    {
       
    }
    private void Update()
    {
        //EnemyAttack();
    }
    public void ChangeState(GameStates newState)
    {
        State = newState;

        switch (newState)
        {
            case GameStates.Movement:
                //Movement();
                break;
            case GameStates.Attack:
                //Attack();
                break;
            case GameStates.Death:
                //Death();
                break;
            default:
                break;
        }
        OnGameStateChanged?.Invoke(newState);
    }

    private void Death()
    {
        throw new NotImplementedException();
    }

    private void Attack()
    {
       
    }

    private void Movement()
    {
        throw new NotImplementedException();
    }

    private void EnemyAttack()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("Attack");
            ChangeState(GameStates.Attack);
        }
    }
}
public enum GameStates
{
    Movement = 0,
    Attack = 1,
    Death = 2
}
