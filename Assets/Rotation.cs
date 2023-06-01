using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    Camera cam;
    void Start()
    {          
        if (cam==null)
        {
            cam = Camera.main;
        }       
    }

    private void LateUpdate()
    {       
        transform.rotation = Quaternion.Euler(60f, cam.transform.rotation.eulerAngles.y, 0f);
    }
}
