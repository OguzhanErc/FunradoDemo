using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [Serializable]
    public class Events : UnityEvent { }

    public Events PlayerDie;
    public Events EnemyDie;

    private void Awake()
    {
        if (instance!=null & instance !=this)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
        }
    }
   
}
