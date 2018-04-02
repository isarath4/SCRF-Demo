using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPS : MonoBehaviour {

	// Use this for initialization
	    public TextMesh fpsText;
     public float deltaTime;
	 void Awake()
	 {
		  Application.targetFrameRate = 300;
	 }
 
     void Update () {
         deltaTime += (Time.deltaTime - deltaTime) * 0.1f;
         float fps = 1.0f / deltaTime;
         fpsText.text = Mathf.Ceil (fps).ToString ();
     }
}
