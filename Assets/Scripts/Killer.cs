using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using System;

public class Killer : MonoBehaviour {

    public float hearingRange;
    
    NavMeshAgent agent;

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        
    }

    private void Update()
    {

    }

    void Roam()
    {

    }
    void Hunting(Vector3 playerPos)
    {
        agent.SetDestination(playerPos);
    }
    void Check()
    {

    }
    void Kill()
    {

    }

}
