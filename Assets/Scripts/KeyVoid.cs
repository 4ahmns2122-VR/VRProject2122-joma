using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyVoid : MonoBehaviour
{
    Box bx;

    private void Start()
    {
        bx = FindObjectOfType<Box>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Key")
        {
            bx.OpenGate();
        }
    }
}