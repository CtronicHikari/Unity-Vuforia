using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class GetVuMarkInfo : DefaultTrackableEventHandler
{
    protected override void OnTrackingFound()
    {
        base.OnTrackingFound();
        Debug.Log(GetInfo(GetComponent<VuMarkBehaviour>().VuMarkTarget));
    }
    private string GetInfo(VuMarkTarget target)
    {
        switch (target.InstanceId.DataType)
        {
            case InstanceIdType.BYTES:
                return target.InstanceId.HexStringValue;
            case InstanceIdType.STRING:
                return target.InstanceId.StringValue;
            case InstanceIdType.NUMERIC:
                return target.InstanceId.NumericValue.ToString();
            default:
                break;
        }
        return "";
    }
}
