using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{
    public AudioSource gateSound;
    Box box;

    private void Start()
    {
        box = FindObjectOfType<Box>();
        box.onSwitched += Open;
    }

    void Open()
    {
        transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y - 50f, transform.rotation.x);
        gateSound.Play();
    }
}
