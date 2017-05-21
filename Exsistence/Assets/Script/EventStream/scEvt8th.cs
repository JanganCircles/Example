using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scEvt8th : MonoBehaviour, iEvent
{
    public GameObject back8;
    public GameObject pencil;
    public GameObject[] Lights = null;

    public void GetiEvent(object obj) { (obj as scEventRunner).SetUpEvt(this); }

    public void Run()
    {
        back8.SendMessage("Open");
        back8.GetComponent<scSetBool>().isLock = true;
        pencil.SetActive(true);

        for (int i = 0; i < Lights.Length; i++)
        {
            Lights[i].SetActive(false);
        }
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
