using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPlayer : MonoBehaviour {

    public AudioSource audioSource;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.LeftArrow)|| Input.GetKeyDown(KeyCode.DownArrow)|| Input.GetKeyDown(KeyCode.RightArrow))
        {
            if(!audioSource.isPlaying)
                audioSource.Play();
        }
        
        
	}
}
