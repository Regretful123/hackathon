using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(RawImage))]
public class MovieStart : MonoBehaviour {
    public MovieTexture movieTex;
    public int SceneToLoad = 1;

	// Use this for initialization
	void Start () {
        // only use this script if it has movie texture assigned to this script
        if (movieTex == null) return;
        // play the movie when possible
        movieTex.Play();
        // invoke a call after the movie is done.
        Debug.Log(movieTex.duration);
        //Invoke("ChangeScene", movieTex.duration);
	}
	
    // change the scene
    void ChangeScene()
    {
        SceneManager.LoadScene(SceneToLoad);
    }
}
