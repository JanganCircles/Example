﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scEvt8th : MonoBehaviour, iEvent
{
    public GameObject Locker;

    public void GetiEvent(object obj) { (obj as scEventRunner).SetUpEvt(this); }

    public void Run()
    {
       // if (Input.GetKey(KeyCode.E))
        //{
            Debug.Log("EEEEEEEEEEEEEEEEEE");
            Locker.GetComponent<scSetBool>().isLock = false;
            Debug.Log("falseeeeeeeeeeee");
        //}
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
