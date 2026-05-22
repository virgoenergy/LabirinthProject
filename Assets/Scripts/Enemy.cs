using System;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    EnemyPath path;

    [SerializeField]
    int currentWaypointIndex = 0;

    bool pathIsFinished;

    private void Start()
    {
        pathIsFinished = false;
    }

    private void Update()
    {
        if (!pathIsFinished)
        {

            transform.position = Vector3.MoveTowards(
                 transform.position,
                 path.GetWaypoint(currentWaypointIndex).position,
                 5f * Time.deltaTime
                 );

            if (Vector3.Distance(transform.position, path.GetWaypoint(currentWaypointIndex).position) < 0.1f)
            {
                currentWaypointIndex++;

                if (currentWaypointIndex > path.GetNumberOfWaypoints() - 1)
                {
                    pathIsFinished = true;
                }
            }
        }
    }



}
