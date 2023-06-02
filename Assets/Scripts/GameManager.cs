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
        if (instance != null & instance != this)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
        }
    }

    public void RestartGame()
    {
        StartCoroutine(EndGameDelay());
    }
    public void NextLevel()
    {
        StartCoroutine(NextLevelDelay());
    }
    IEnumerator EndGameDelay()
    {
        yield return new WaitForSeconds(5f);
        string currentSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentSceneName);

    }
    IEnumerator NextLevelDelay()
    {
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
