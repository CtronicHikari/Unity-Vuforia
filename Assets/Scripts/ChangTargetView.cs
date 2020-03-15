using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ChangTargetView : MonoBehaviour
{
    // Start is called before the first frame update
    private ModelTargetBehaviour targetBehaviour;

    private void Awake()
    {
        targetBehaviour = GetComponent<ModelTargetBehaviour>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            int count = targetBehaviour.ModelTarget.GetNumGuideViews();
            int index = Random.Range(0, count);
            targetBehaviour.ModelTarget.SetActiveGuideViewIndex(index);
            print("current GuideView index" + index);
        }
    }
}
