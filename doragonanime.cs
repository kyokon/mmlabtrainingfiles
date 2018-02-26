using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using System;
using System.IO.Ports;
using System.Runtime.InteropServices;

public class doragonanime : MonoBehaviour {
	public static SerialLib.MyClass serial;
	public Animator anime;

	private string s;

	// Use this for initialization
	void Start () {
		anime = GetComponent<Animator> ();
		serial = new SerialLib.MyClass ("COM8", 9600, 256);
		serial.ThreadStart ();
	}
	
	// Update is called once per frame
	void Update () {
		s = serial.GetData ();
		Debug.Log ("value = "+s);
		if (s == "a") {
			anime.Play ("wings");
			Debug.Log ("animePlaying");
		} else {
			anime.Play ("Idle");
		}
	}
	void OnDestroy()
	{
		serial.ThreadEnd ();
	}


}
