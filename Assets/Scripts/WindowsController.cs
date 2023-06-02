using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WindowsController : MonoBehaviour
{
    NavMeshAgent playerNavMesh;
    Camera playerCam;
    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
        playerNavMesh = GetComponent<NavMeshAgent>();
        playerCam = Camera.main;
    }


    void Update()
    {
        Movement();

    }
    void Movement()
    {
        if (Input.GetMouseButton(0))
        {
            Ray myRay = playerCam.ScreenPointToRay(Input.mousePosition);
            RaycastHit myRaycastHit;

            if (Physics.Raycast(myRay, out myRaycastHit))
            {
                anim.SetBool("isMoving", true);
                playerNavMesh.SetDestination(myRaycastHit.point);
            }
            else
            {
                anim.SetBool("isMoving", false);
            }
        }
    }
}
