using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scEvt10th : MonoBehaviour, iEvent
{
    public scEventRunner Runner;
    public GameObject light;
    private int MsgCount = 0;
    private int EventCount = 3;

    public void GetiEvent(object obj) { (obj as scEventRunner).SetUpEvt(this); }

    void Start ()
    {
        Runner.SetEvent(this);
    }

    public void Run()
    {
        --EventCount;
        if (EventCount == 2)
        {
            scMsg.CreateNewMessage("안와?");
            Runner.isTimerRun();
        }
        if(EventCount == 1)
        {
            scMsg.CreateNewMessage("기다려");
            Runner.isTimerRun();
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "Player" && Input.GetKeyDown(KeyCode.E))
        {
            if (MsgCount == 0)
            {
                MsgCount++;

                scMsg.CreateNewMessage("11반으로 와라. 3분");
                light.SetActive(true);

                Runner.isTimerRun();
            }
        }
    }
}
