﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 작성자 : 우신현

public class scEventRunner : MonoBehaviour {

    public enum EventStasis
        //이벤트 상태
    {
        COLLISION,
        TIME,
        LOGICCAL,
    }
    
    private List<iEvent> evts;
    [SerializeField]
    public GameObject[] Evts = null;
    public int evtidx;  //이벤트 인덱스 변수
    public bool MainEvent = true;  //메인 이벤트, 서브 이벤트 구분 변수
    public EventStasis eStasis;         //이벤트 상태
    
    public float TImer = 0;                 //타이머러너일때만 사용
    void Awake () {
        evts = new List<iEvent>();
        for (int i = 0; i < Evts.Length; i++)
        {
            Evts[i].SendMessage("GetiEvent",this);
        }
    }
    public void SetUpEvt(object obj)
    {
        evts.Add(obj as iEvent);
    }
    void Start () { }
    void Update () {    }

    public void SetEvent(iEvent ev)
    {
        evts.Add(ev);
    }
    public void isRunEvent()
    {
        if (eStasis != EventStasis.LOGICCAL)
        {
            return;
        }
        RunAllEvent();

    }
    public void isTimerRun()
    {
        if (eStasis != EventStasis.TIME)
        {
            return;
        }
        StartCoroutine("TimerRun");
    }

    IEnumerator TimerRun()
    {
        float MaxTIme = TImer;
        while (MaxTIme > 0)
        {
            MaxTIme -= Time.deltaTime;
            yield return null;
        }
        RunAllEvent();

    }
    void OnTriggerEnter(Collider coll)    //충돌처리
    {

        if (MainEvent && evtidx != scGameManager.instance.eventIndex)
        {
            return;
        }
        if (eStasis != EventStasis.COLLISION)
        {
            gameObject.GetComponent<SphereCollider>().enabled = false;
            return;
        }
        Debug.Log("충돌하였음");
        
        Debug.Log(evtidx);
        Debug.Log(scGameManager.instance.eventIndex);
        RunAllEvent();

            if (MainEvent)
            { scGameManager.instance.eventIndex++; }
            
            Debug.Log("GameManager의 eventIndex : " + scGameManager.instance.eventIndex);
            Debug.Log("Runner의 evtidx : " + evtidx);
            
    }
    public void RunAllEvent()
    {
        for (int i = 0; i < evts.Count; i++)
        {
            evts[i].Run();
        }
    }
}

public interface iEvent
{
    void Run();
    void GetiEvent(object M);
}
