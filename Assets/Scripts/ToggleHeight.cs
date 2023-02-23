using System.Collections;
using System.Collections.Generic;
using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ToggleHeight : MonoBehaviour
{
    private XROrigin _xROrigin;
    public enum TrackingOriginMode {Floor,Device};


    // Start is called before the first frame update
    void Start()
    {
        _xROrigin = GetComponent<XROrigin>();
        
    }

    public void SwitchHeight(int heightValue)
    {
        if (heightValue == 0)
        {
            EnableFloorTracking();
        }
        else if (heightValue == 1)
        {           
            EnableDeviceTracking();
        }
    }

    private void EnableFloorTracking()
    {
        //XROrigin.TrackingOriginMode;
        var mode = TrackingOriginMode.Floor;
    }

    private void EnableDeviceTracking()
    {
        var mode = TrackingOriginMode.Device;
    }

}
