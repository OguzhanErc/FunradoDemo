using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
   
    public bool enemyLevelHigher;
    public bool playerLevelHigher;
    public bool isPlayerDead;
    public bool isEnemyDead;

    
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
