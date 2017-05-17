using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scEventMain2 : MonoBehaviour ,iEvent{
    public scSound sound;

	// Use this for initialization
	void Update () {

    }
    public void Run()
    {
        sound.Run();
    }
    
    public void GetiEvent(object obj) { (obj as scEventRunner).SetUpEvt(this); }
}
