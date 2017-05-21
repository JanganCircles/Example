using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scEvt12th : MonoBehaviour, iEvent
{
    public scEventRunner Runner;
    public GameObject[] Light;

    public void GetiEvent(object obj) { (obj as scEventRunner).SetUpEvt(this); }

    void Start ()
    {
        Runner.SetEvent(this);
    }

    public void Run()
    {
        scMsg.DeleteMessage("11반으로 와라. 3분");
        scMsg.DeleteMessage("안와?");
        scMsg.DeleteMessage("기다려");

        Light[0].SetActive(false);
        Light[1].SetActive(true);
    }
}
