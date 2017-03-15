using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRSwitch : MonoBehaviour {
    private bool isVR = false;

	// Use this for initialization
    public void SwitchVR()
    {
        Debug.Log("Switching VR");
        isVR = !isVR;
        Vuforia.DigitalEyewearARController.Instance.SetViewerActive(isVR);
    }
}
