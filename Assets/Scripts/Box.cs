using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Box : MonoBehaviour
{
    public event Action onSwitched;

    void OpenDoor()
    {
        onSwitched();
    }
}
