using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using System;

public class Killer : MonoBehaviour {

    public float hearingRange;
    public event Action heardSmth;
    public delegate void heardSmthDelegate();
    

    NavMeshAgent agent;
    Vector3 targetpos;


    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        //Hear();
        if (false)
        {
            Roam();
        }
        else if (true)
        {
            Hunting();
        }
    }

    /*
    Vector3 Hear()
    {
        bool hearing = false;
        Vector3 hearingpos = new Vector3(0,0,0);

        if (hearing)
        {
            return new Vector3(1, 2, 0);
        }
        else
        {
            //return null;
        }

    }
    */
    void Roam()
    {

    }
    void Hunting()
    {

    }
    void Check()
    {

    }
    void Kill()
    {

    }


    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, hearingRange);
    }
}
