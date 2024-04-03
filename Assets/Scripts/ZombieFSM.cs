using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieFSM : MonoBehaviour
{
    public float chaseRange = 10f;
    public GameObject player;
    private bool isChasing = false;

    void Update()
    {
        float distanceToPlayer = Vector3.Distance(transform.position, player.transform.position);

        if (distanceToPlayer <= chaseRange)
        {
            if (!isChasing)
            {
                // Transition to chase state
                StartChase();
            }
        }
        else
        {
            if (isChasing)
            {
                // Transition to idle state
                StopChase();
            }
        }
    }

    void StartChase()
    {
        isChasing = true;
        // Activate NavMesh and Rat Follow scripts or any other chase behavior
        GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = true; // Enable NavMeshAgent
        GetComponent<ratFollow>().enabled = true; // Enable RatFollow script
    }

    void StopChase()
    {
        isChasing = false;
        // Deactivate NavMesh and Rat Follow scripts or any other chase behavior
        GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = false; // Disable NavMeshAgent
        GetComponent<ratFollow>().enabled = false; // Disable RatFollow script
    }
}

