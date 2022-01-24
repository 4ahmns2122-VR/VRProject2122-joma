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

        Handles.color = Color.blue;
        Vector3 corner1 = new Vector3(kllr.areaXMinMax.x, 0,kllr.areaZMinMax.x);
        Vector3 corner2 = new Vector3(kllr.areaXMinMax.y, 0, kllr.areaZMinMax.x);
        Vector3 corner3 = new Vector3(kllr.areaXMinMax.y, 0, kllr.areaZMinMax.y);
        Vector3 corner4 = new Vector3(kllr.areaXMinMax.x, 0, kllr.areaZMinMax.y);
        Handles.DrawAAPolyLine(corner1, corner2, corner3, corner4, corner1);
    }
}
