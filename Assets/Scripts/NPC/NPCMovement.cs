using System;
using UnityEngine;
using UnityEngine.AI;

public class NPCMovement : MonoBehaviour
{
    [SerializeField] private NavMeshAgent agent;
    [SerializeField] private Transform target;

    public void MoveTo(Vector3 destination)
    {
        agent.SetDestination(destination);
    }

    private void Start()
    {
        MoveTo(target.position);
    }
}
