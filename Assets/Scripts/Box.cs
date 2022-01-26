using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Box : MonoBehaviour
{
    public Animation doorAnim;
    public event Action onSwitched;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Key")
        {
            doorAnim.Play();
        }
    }

    void OpenGate()
    {
        onSwitched();
    }
}
