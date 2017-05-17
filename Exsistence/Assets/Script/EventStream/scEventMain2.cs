using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scEventMain2 : MonoBehaviour ,iEvent{
    public scSound sound;
    public static int EventCount;
	// Use this for initialization
	void Update () {

        if (Input.GetKeyDown(KeyCode.E))
        {
            EventCount++;
        }
    }



	
    public void Run()
    {
        sound.Run();
    }
    
    public void GetiEvent(object obj) { (obj as scEventRunner).SetUpEvt(this); }
}
