﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scEventLight : MonoBehaviour,iEvent {
    public scRunner Runner;
    public GameObject obj;

	// Use this for initialization
	void Start ()
    {
        Runner.SetEvent(this);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Run()
    {
        obj.SetActive(false);
    }
}
