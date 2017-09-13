using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrintTime : MonoBehaviour {

    public Text label;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        label.text = "Time: " + System.DateTime.Now;
	}
}
