﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scMsg : MonoBehaviour {
    public static List<GameObject> msgList = new List<GameObject>();
    public static GameObject msgCanvas;
    public static scSound sound1;
	// Use this for initialization
	void Start () {
        sound1 = GameObject.FindGameObjectWithTag("BGM").GetComponent<scSound>();
        //msgList = null;
        msgCanvas = GameObject.FindWithTag("msgCanvas");
        if (msgCanvas != null)
        {
            CreateNewMessage("안녕...");
            Debug.Log("아아아아");
            MessageUnvis();
        }
        scMsg.CreateNewMessage("올때 메로나");
    }
	
	// Update is called once per frame
	void Update () {
	}
    public static void CreateNewMessage(string str) {
        print("CreateNewMessage : " + str);
        msgList.Add(Instantiate(msgCanvas));
        msgList[msgList.Count -1].transform.GetChild(0).GetChild(0)
            .GetComponent<Transform>().GetComponent<Text>().text = str;
        ReMessage();
        sound1.Run();
    }
    public static void DeleteMessage(int index) {
        Destroy(msgList[index]);
        msgList.RemoveAt(index);
        
        ReMessage();
    }
    public static void DeleteMessage(string TextValue) {
        Destroy(msgList.Find(msgList => msgList.name.Contains("TextValue")));
        msgList.Remove(msgList.Find(msgList => msgList.name.Contains("TextValue")));
        ReMessage();
    }
    public static void ReMessage()
    {
        for (int i = 0; i < msgList.Count; i++) {
               msgList[i].transform.GetChild(0).GetComponent<Transform>()
                .GetComponent<RectTransform>().localPosition = (new Vector3(193, 70-(i*40), 0));
        }
    }
    public static void MessageVis()
    {
        for (int i = 0; i < msgList.Count; i++)
        {
            msgCanvas.SetActive(true);
            msgList[i].SetActive(true);
        }
    }
    public static void MessageUnvis()
    {
        for (int i = 0; i < msgList.Count; i++)
        {
            msgCanvas.SetActive(false);
            msgList[i].SetActive(false);
        }
    }

}
