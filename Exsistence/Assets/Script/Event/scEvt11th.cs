using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scEvt11th : MonoBehaviour, iEvent
{
    public scEventRunner Runner;
    public GameObject light;
    public string Msg;

    private int MsgCount = 0;
    private int eventCount = 0;

    public void GetiEvent(object obj) { (obj as scEventRunner).SetUpEvt(this); }

    void Start ()
    {
        Runner.SetEvent(this);
    }

    void Update()
    {
        if(eventCount < 2)
        {
            Runner.isRunning = false;
        }
        else if(eventCount == 2)
        {
            scGameManager.instance.eventIndex = -3;
        }
    }

    public void Run()
    {
        if (scGameManager.instance.eventIndex != 11)
            return;

        ++eventCount;

        scMsg.CreateNewMessage(Msg);

        Msg = "기다려";

        Runner.isTimerRun();
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
