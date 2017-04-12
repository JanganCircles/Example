﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class scPhone : MonoBehaviour, IPointerEnterHandler,IPointerExitHandler
{
    public static bool play = true;
    private int iphone = 0;
    private int imsgList = 0;
    private int iinMeno = 0;
    private int imemo1_1 = 0;
    GameObject phone;
    GameObject msgList;
    GameObject back;
    GameObject inMemo;
    GameObject memo1_1;
    public void OnPointerEnter(PointerEventData data)
    {
        Debug.Log("MouseOver");
        play = false;
        Cursor.visible = true;
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        Cursor.visible = false;
        play = true;
    }

    // Use this for initialization
    void Start () {
        Cursor.visible = false;
        phone = transform.Find("Phone").gameObject;
        msgList = transform.GetChild(0).Find("MsgList").gameObject;
        back = transform.GetChild(0).Find("Back").gameObject;
        inMemo = transform.GetChild(0).Find("InMemo").gameObject;
        memo1_1 = transform.GetChild(0).GetChild(3).Find("memo1_1").gameObject;
        memo1_1.SetActive(false);
        inMemo.SetActive(false);
        msgList.SetActive(false);
        back.SetActive(false);
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Tab)){
            if (iphone == 0)
            { phone.SetActive(true); iphone = 1;}
            else
            { phone.SetActive(false); iphone = 0; }
        }
        
    }
    public void VisibleMsg() {
        Debug.Log("뭐");
        msgList.SetActive(true);
        imsgList = 1;
        back.SetActive(true);
    }
    public void VisibleInMemo()
    {
        inMemo.SetActive(true);
        iinMeno = 1;
        back.SetActive(true);
    }
    public void Memo()
    {
        memo1_1.SetActive(true);
        imemo1_1 = 1;
        back.SetActive(true);
    }
    public void Back() {
        if (imsgList == 1) {
            msgList.SetActive(false);
            imsgList = 0;
        }
        if (iinMeno == 1)
        {
            inMemo.SetActive(false);
            iinMeno = 0;
        }
        if (imemo1_1 == 1) {
            memo1_1.SetActive(false);
            imemo1_1 = 0;
        }
        back.SetActive(false);
    }
}
