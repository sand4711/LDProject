﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinSCript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Overlord") {
            SceneManager.LoadScene(3);
            //FMOD SOUND
            FMODUnity.RuntimeManager.PlayOneShot("event:/Victory", new Vector3(0, 0, 0));
        }
    }
}
