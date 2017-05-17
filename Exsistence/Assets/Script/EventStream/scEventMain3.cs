using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scEventMain3 : MonoBehaviour , iEvent {
  
    

    // Use this for initialization
    void Start () {
        

    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.E))
        {
            scEventMain2.EventCount++;
        }
        if (scEventMain2.EventCount == 2)
        {
            scMsg.CreateNewMessage("문자_1수신");
        }
    }

    public void GetiEvent(object obj) { (obj as scEventRunner).SetUpEvt(this); }

    public void Run()
    {
        scEventMain2.EventCount++;
    }
}
