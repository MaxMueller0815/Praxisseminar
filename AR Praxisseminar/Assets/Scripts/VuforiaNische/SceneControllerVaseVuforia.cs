﻿using UnityEngine;

public class SceneControllerVaseVuforia : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        if (Screen.orientation != ScreenOrientation.Landscape)
        {
            Screen.orientation = ScreenOrientation.LandscapeLeft;

            Screen.orientation = ScreenOrientation.AutoRotation;
            Screen.autorotateToPortrait = false;
            Screen.autorotateToPortraitUpsideDown = false;
        }

    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            LevelManager.LoadLastScene();
        }
    }
}
