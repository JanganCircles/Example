using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scSetting : MonoBehaviour
{
    static float ambientValue = 1f;
    static float audioVolume = 1f;

    static bool resol = false;

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
        // 슬라이더 생성
        GUI.Box(new Rect(Screen.width / 2 -3, Screen.height / 2 -20, 105, 35), "화면 밝기");
        ambientValue = GUI.HorizontalSlider(new Rect(Screen.width / 2, Screen.height / 2, 100, 50), ambientValue, 0f, 1.0f);

        GUI.Box(new Rect(Screen.width / 2 -3, Screen.height / 2 -120, 105, 35), "오디오 볼륨");
        audioVolume = GUI.HorizontalSlider(new Rect(Screen.width / 2, Screen.height / 2 -100, 100, 50), audioVolume, 0f, 1.0f);

        GUI.Box(new Rect(Screen.width / 2 -3, Screen.height / 2 +80, 125, 40), "해상도");
        resol = GUI.Toggle(new Rect(Screen.width / 2, Screen.height / 2 +100, 105, 35), resol, "16 : 9");
        resol = GUI.Toggle(new Rect(Screen.width / 2 +60, Screen.height / 2 + 100, 105, 35), !resol, "4 : 3");

        Setting();
    }

    private void Setting()
    {
        //화면 밝기 설정
        RenderSettings.ambientLight = new Color(ambientValue, ambientValue, ambientValue, 1);

        //오디오 설정
        if (GameObject.FindObjectsOfType(typeof(AudioSource)) != null)
        {
            foreach (AudioSource audioComponent in GameObject.FindObjectsOfType(typeof(AudioSource)))
            {
                audioComponent.volume = audioVolume;

                audioComponent.Stop();
                audioComponent.Play();
            }
        }

        //해상도 설정
        if(resol)
        {
            // Screen.SetResolution(Screen.width / 16, Screen.height / 9, true);
            Camera.main.aspect = 1600/900;
            Debug.Log(Camera.main.aspect);
        }
        else if(!resol)
        {
            //Screen.SetResolution(Screen.width / 4, Screen.height / 3, true);
            Camera.main.aspect = 1024/768;
            Debug.Log(Camera.main.aspect);
        }
    }
}
