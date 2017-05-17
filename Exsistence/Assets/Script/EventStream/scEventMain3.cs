using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scEventMain3 : MonoBehaviour , iEvent {

    int EventCount = 0;

    // Use this for initialization
    void Start () {
        

    }
	
	// Update is called once per frame
	void Update () {

      

    }
    
    void OnTriggerStay(Collider col)
    {
        Debug.Log("방화문 트리거스테이 들어왔음  ");
        if (col.gameObject.tag == "Firedoor")
        {
            Debug.Log("Firedoor 태그 확인 완료   ");
            if (Input.GetKeyDown(KeyCode.E) && EventCount < 2)
            {
                EventCount++;
                Debug.Log("EventCount : " + EventCount);
            }
            if (Input.GetKeyDown(KeyCode.E) && EventCount == 2)
            {
                scMsg.CreateNewMessage("문자_1수신");
                Debug.Log("2 == EventCount : 문자수신됨 ");
            }

        }
    }

    public void GetiEvent(object obj) { (obj as scEventRunner).SetUpEvt(this); }

    public void Run()
    {
        
    }
}
