using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public float minHeight, maxHeight;
    public float speed = 3f;

    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + Mathf.Clamp(Mathf.Sin(Time.time * speed), minHeight * 0.01f, maxHeight * 0.01f), transform.position.z);
    }
}
