using NUnit.Framework;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemyPath : MonoBehaviour
{
    [SerializeField]
    List<Transform> waypoints;

    private void Awake()
    {
        // Initialize the list
        waypoints = new List<Transform>();

       foreach (Transform waypoint in transform)
        {
            waypoints.Add(waypoint);
        }
    }


    public Transform GetWaypoint(int index)
    {
        return waypoints[index];
    }

    public int GetNumberOfWaypoints()
    {
        return waypoints.Count;
    }

}
