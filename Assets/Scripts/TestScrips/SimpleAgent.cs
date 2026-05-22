using UnityEngine;
using UnityEngine.AI;

public class SimpleAgent : MonoBehaviour
{

    [SerializeField]
    Transform target;

    NavMeshAgent agent;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        agent.enabled = true;

       
    }

    private void Update()
    {
        agent.SetDestination(target.position);
    }

}
