using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemyai : MonoBehaviour
{
    private enemyawareness enemyawareness;
    private Transform playersTransform;
    private NavMeshAgent enemynavMeshAgent;



    public scorescript scorescript;
    
    private void Start()
    {
        enemyawareness = GetComponent<enemyawareness>();
        playersTransform = FindObjectOfType<PlayerMovementTutorial>().transform;
        enemynavMeshAgent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        
        if (enemyawareness.isAggro == true && scorescript.tutorialComplete == true) 
        { 
          enemynavMeshAgent.SetDestination(playersTransform.position);
        }
    }
}
