using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scEvt5th : MonoBehaviour, iEvent
{
    public void GetiEvent(object obj) { (obj as scEventRunner).SetUpEvt(this); }

    void iEvent.Run()
    {
        //gameObject.SetActive(true);
        gameObject.transform.GetChild(2).gameObject.SetActive(true);
    }

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
