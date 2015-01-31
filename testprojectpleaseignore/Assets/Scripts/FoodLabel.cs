﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FoodLabel : MonoBehaviour {
	// Public Text Field for use with editor.
	public Text foodLabel;


	// Use this for initialization
	void Start () {
		if(foodLabel != null) {
			foodLabel.text = "0";
		}
	}
	
	// Update is called once per frame
	void Update () {
		if(foodLabel != null) {
			foodLabel.text = ResourceTracker.instance.getFood().ToString();
		}
	}
}
