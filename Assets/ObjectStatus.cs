using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vuforia;

public class ObjectStatus : MonoBehaviour, ITrackableEventHandler {
    private TrackableBehaviour mtrackbehavior;
    public string loadLevel;

    void Start()
    {
        mtrackbehavior = GetComponent<TrackableBehaviour>();
        if(mtrackbehavior)
            mtrackbehavior.RegisterTrackableEventHandler(this);
    }

    public void OnTrackableStateChanged( TrackableBehaviour.Status previousStatus, 
                                        TrackableBehaviour.Status newStatus)
    {
        if ( newStatus == TrackableBehaviour.Status.DETECTED || 
            newStatus == TrackableBehaviour.Status.TRACKED)
        {
            StartChanginglevel();
        }
    }

    // Use this for initialization
    private void StartChanginglevel () {
        if (!PlayerPrefs.HasKey("Unlock"))
        {
            PlayerPrefs.SetString("Unlock", "NULL");
            PlayerPrefs.Save();
        }
        SceneManager.LoadScene(loadLevel);
	}
}
