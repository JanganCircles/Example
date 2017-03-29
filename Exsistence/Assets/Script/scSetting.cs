using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scSetting : MonoBehaviour
{
    static float ambientValue = 0f;

    public void Awake()
    { 
        Setting();

        DontDestroyOnLoad(this.gameObject);

        scSceneMove.SettingCanvas = GameObject.Find("SettingCanvas");

        this.transform.parent.gameObject.SetActive(false);
    }

    private void OnGUI()
    {
        //x 스크린.X / 2 - 400, y 스크린.y / 2 + 250 위치에 가로, 세로 100, 50 인 슬라이더를 생성(최소 0, 최대 1);
        // 슬라이더 생성 및 조절
        ambientValue = GUI.HorizontalSlider(new Rect(Screen.width / 2, Screen.height / 2, 100, 50), ambientValue, 0f, 1.0f);
        Setting();
    }

    private void Setting()
    { 
        //화면 밝기 설정
        RenderSettings.ambientLight = new Color(ambientValue, ambientValue, ambientValue, 1);

        Debug.Log("ambientValue" + ambientValue);
        Debug.Log("ambientLight" + RenderSettings.ambientLight);
    }
}
