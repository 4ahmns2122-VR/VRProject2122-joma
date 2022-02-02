using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Box : MonoBehaviour
{
    public Animation doorAnim;
    public AudioSource doorSound;
    public event Action onSwitched;

    Killer kllr;

    private void Start()
    {
        kllr = FindObjectOfType<Killer>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Key")
        {
            doorAnim.Play();
            doorSound.Play();
            kllr.Hunting(gameObject.transform.position);
        }
    }

    public void OpenGate()
    {
        onSwitched();
    }
}
