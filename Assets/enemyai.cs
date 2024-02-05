using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemyai : MonoBehaviour
{
    private enemyawareness enemyawareness;
    private Transform playersTransform;
    private NavMeshAgent enemynavMeshAgent;

    private void Start()
    {
        enemyawareness = GetComponent<enemyawareness>();
        playersTransform = FindObjectOfType<PlayerMovementTutorial>().transform;
        enemynavMeshAgent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        enemynavMeshAgent.SetDestination(playersTransform.position);
    }
}
