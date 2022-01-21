using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor (typeof (Killer))]
public class KillerEditor : Editor
{

    private void OnSceneGUI()
    {
        Killer kllr = (Killer)target;
        Handles.color = Color.white;
        Handles.DrawWireDisc(kllr.transform.position, Vector3.up, kllr.hearingRange);
    }
}
