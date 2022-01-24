using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using System;

public class Killer : MonoBehaviour {

    public float hearingRange = 20f;
    public Vector2 areaXMinMax, areaZMinMax;
    public float destinationThreshold = 2f;
    public float checkTime = 4f;

    NavMeshAgent agent;
    bool isHunting = false;

    private void Awake()
    {
        //Get Agent
        agent = GetComponent<NavMeshAgent>();
        //Initialize Movement
        agent.SetDestination(RandomDestination());
    }
    private void Update()
    {
        Movement();
    }

    void Movement()
    {
        if (agent.remainingDistance <= destinationThreshold && !isHunting)
        {
            agent.SetDestination(RandomDestination());
            print("direction changed");
        }
        else if(agent.remainingDistance <= destinationThreshold && isHunting)
        {
            Check();
        }
    }
    void Hunting(Vector3 soundPos)
    {
        if (Vector3.Distance(soundPos, transform.position) <= hearingRange)
        {
            agent.SetDestination(soundPos);
            isHunting = true;
        }
    }
    void Check()
    {
        agent.isStopped = true;

    }
    void Kill()
    {

    }
    Vector3 RandomDestination()
    {
        Vector3 newRandomDestination = new Vector3(UnityEngine.Random.Range(areaXMinMax.x, areaXMinMax.y), 0, UnityEngine.Random.Range(areaZMinMax.x, areaZMinMax.y));
        return newRandomDestination;
    }
}
