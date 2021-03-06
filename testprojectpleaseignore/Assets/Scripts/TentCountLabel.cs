﻿using UnityEngine;
using System;
using System.Collections;
using UnityEngine.UI;

public class TentCountLabel : MonoBehaviour {
	// Public Text Field for use with editor.
	public Text tentCount;
	
	
	// Use this for initialization
	void Start () {
		if(tentCount != null) {
			tentCount.text = "0";
		}
	}
	
	// Update is called once per frame
	void Update () {
		if(tentCount != null) {
			tentCount.text = String.Format("{0,5:N1}", BuildingTracker.instance.getCount(0));
		}
	}
}