using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLevelSystem : MonoBehaviour
{
    public int currentLevel;

    private void Start()
    {
        currentLevel = 10;
    }
    private void Update()
    {
        if (currentLevel==0)
        {
            Debug.Log("Level Dustu");
        }
    }
}
