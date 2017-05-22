﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scEvt12th : MonoBehaviour, iEvent
{
    public scEventRunner Runner;
    public GameObject[] Light;
    public int msgIndex;

    public void GetiEvent(object obj) { (obj as scEventRunner).SetUpEvt(this); }

    void Start ()
    {
        Runner.SetEvent(this);
    }

    public void Run()
    {
        for (int i = msgIndex; i > msgIndex - 2; i --)
        {
            if (scMsg.msgList[msgIndex] != null)
            {
                scMsg.DeleteMessage(msgIndex);
            }
        }

        Light[0].SetActive(false);
        Light[1].SetActive(true);
    }
}
