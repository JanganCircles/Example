using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scEventMain1 : MonoBehaviour {
    public GameObject gameobj;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update()
    {

    }

    void EVT()
    {
        gameobj.SetActive(false);
    }



}
