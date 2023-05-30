using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyMovement : MonoBehaviour
{
    NavMeshAgent agent;
    public Transform[] waypoints;
    int waypointIndex;
    Vector3 target;
    public bool isEnemyStopped;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        UpdateDestination();
    }


    void Update()
    {
        if (Vector3.Distance(transform.position,target)<1)
        {
            ItarateWaypointIndex();
            UpdateDestination();
            if (isEnemyStopped)
            {
                agent.isStopped = true;
            }
        }
    }
   void UpdateDestination()
    {
        target = waypoints[waypointIndex].position;
        agent.SetDestination(target);
    }
    void ItarateWaypointIndex()
    {
        waypointIndex++;
        if (waypointIndex==waypoints.Length)
        {
            waypointIndex = 0;
        }
    }
   
}
