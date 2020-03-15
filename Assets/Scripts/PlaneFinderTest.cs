using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class PlaneFinderTest : MonoBehaviour
{
    public void AutomaticHitTest(HitTestResult result)
    {
        print(result.Position + " " + result.Rotation);
    }

    public void ContentPlaced(GameObject go)
    {
        go.transform.GetChild(0).localEulerAngles = new Vector3(Random.Range(10, 90), 0, 0);
        print(go.name);
    }
}
