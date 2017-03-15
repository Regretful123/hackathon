using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ForceFix : MonoBehaviour {

    public VRSwitch toggleVR;

	// Use this for initialization
	void Start () {
        toggleVR.SwitchVR();
        toggleVR.SwitchVR();
    }
}
