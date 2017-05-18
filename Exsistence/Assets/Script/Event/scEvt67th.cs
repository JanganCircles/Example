using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scEvt67th : MonoBehaviour, iEvent {

    public GameObject Posi;
    public GameObject Player;

    public void GetiEvent(object obj) { (obj as scEventRunner).SetUpEvt(this); }

    public void Run()
    {
        DontDestroyOnLoad(Posi);
        Posi.transform.position = Player.transform.position;
        Posi.transform.rotation = Player.transform.rotation;
        SceneManager.LoadScene("EvtShinHyeon_no11");
        //Player = gameObject.transform.Find("Player").gameObject;
        Player.transform.position = Posi.transform.position;
        Player.transform.rotation = Posi.transform.rotation;
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
