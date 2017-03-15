using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class URLlink : MonoBehaviour {

    // open website page using the assigned url
	public void GoToWebsite(string url )
    {
        Application.OpenURL(url);
    }

    // if you know the level name, use this
    public void LoadLevel(string level)
    {
        SceneManager.LoadScene(level);
    }

    // iof you know where the level is position in the build setting, use this.
    public void LoadLevel( int level )
    {
        SceneManager.LoadScene(level);
    }
}
