using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI; // Include the NavMesh namespace

public class WaypointMove : MonoBehaviour
{
    public List<GameObject> waypoints;
    public float speed = 2;
    int index = 0;
    public bool isLoop = true;
    private NavMeshAgent navMeshAgent; // Reference to the NavMeshAgent component
    private ratFollow ratFollowScript;

    void Start()
    {
        // Get the NavMeshAgent component attached to this GameObject
        navMeshAgent = GetComponent<NavMeshAgent>();
        ratFollowScript = GetComponent<ratFollow>();
    }

    void Update()
    {
        // Check if the NavMeshAgent is active, if yes, stop moving along waypoints
        if (navMeshAgent != null && navMeshAgent.enabled || ratFollowScript.enabled){
            return;
        }

        Vector3 destination = waypoints[index].transform.position;
        Vector3 newPos = Vector3.MoveTowards(transform.position, destination, speed * Time.deltaTime);
        transform.position = newPos;

        float distance = Vector3.Distance(transform.position, destination);
        if (distance <= 0.05)
        {
            if (index < waypoints.Count - 1)
            {
                index++;
            }
            else
            {
                if (isLoop)
                {
                    index = 0;
                }
            }
        }
    }
}
