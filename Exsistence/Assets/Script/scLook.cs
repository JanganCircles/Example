﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scLook : MonoBehaviour {
    public Transform target;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        target.LookAt(target);
	}
}
