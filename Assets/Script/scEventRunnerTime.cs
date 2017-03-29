using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 작성자 : 우신현

public class scEventRunnerTime : MonoBehaviour {

    iEvent evt;
    public int evtidx;  //이벤트 인덱스 변수

    void Awake() { }
    void Start() { }
    void Update() { }

    public void SetEvent(iEvent ev)
    {
        evt = ev;
    }

    void OnTriggerEnter(Collider coll)    //충돌처리
    {
        Debug.Log("충돌하였음");
        Debug.Log(evtidx);
        Debug.Log(scGameManager.instance.eventIndex);

        if (evtidx == scGameManager.instance.eventIndex)
        {
            evt.Run();

            scGameManager.instance.eventIndex++;
            Debug.Log("GameManager의 eventIndex : " + scGameManager.instance.eventIndex);
            Debug.Log("Runner의 evtidx : " + evtidx);
        }
    }
}