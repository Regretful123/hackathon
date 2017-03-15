using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

[RequireComponent(typeof(RawImage))]    
public class MovieStart : MonoBehaviour {
    //public MovieTexture movieTex;
    public int SceneToLoad = 1;
    public float timetowait = 1.03f;
    private float i = 0;

	// Use this for initialization
	void Start () {
        Handheld.PlayFullScreenMovie("IntroMovie.mp4");
        // only use this script if it has movie texture assigned to this script
        //if (movieTex == null) return;
        // play the movie when possible
        //movieTex.Play();
        // invoke a call after the movie is done.
        //float t = movieTex.duration;
        //Invoke("ChangeScene", movieTex.duration);
    }

    private void FixedUpdate()
    {
        i += Time.fixedDeltaTime;
        if ( i > timetowait )
        {
            ChangeScene();
            i = 0;
        }
    }

    // change the scene
    public void ChangeScene()
    {
        //if (!PlayerPrefs.HasKey("Unlock"))
        //{
            SceneManager.LoadScene(1);
        //}
        //else
        //{
        //    SceneManager.LoadScene("Menu");
        //}
        
    }
}
