using System;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    EnemyPath path;

    [SerializeField]
    int currentWaypointIndex = 0;

    NavMeshAgent agent;

    bool pathIsFinished;



    private void Start()
    {
        //Fetch components
        agent = GetComponent<NavMeshAgent>();

        // Initial settings
        pathIsFinished = false;

        //Enable agent
        agent.enabled = true;

        // Set initial destination
        agent.SetDestination(path.GetWaypoint(currentWaypointIndex).position);
    }

    private void Update()
    {
        // Keep navigating for as long as the path is NOT finished
        if (!pathIsFinished && path != null)
        {

            // Only go further if the agent is ready
            if (agent.hasPath && !agent.pathPending)
            {
                // Are we there yet?
                if (agent.remainingDistance < .5f)
                {
                    // Increment the current waypoint index
                    currentWaypointIndex++;

                    // Did we finish the path?
                    if (currentWaypointIndex > path.GetNumberOfWaypoints() - 1)
                    {
                        pathIsFinished = true;
                        return;
                    }
                    agent.SetDestination(path.GetWaypoint(currentWaypointIndex).position);
                }
            }
        }
    }

    public void SetPath(EnemyPath newPath)
    {
        path = newPath;
    }



}
