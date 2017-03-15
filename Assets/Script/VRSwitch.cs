using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRSwitch : MonoBehaviour {
    public bool isVR = false;

    private void Start()
    {
        Vuforia.DigitalEyewearARController.Instance.SetViewerActive(isVR);
    }
    
	// Use this for initialization
    public void SwitchVR()
    {
        isVR = !isVR;
        Vuforia.DigitalEyewearARController.Instance.SetViewerActive(isVR);
    }
}
