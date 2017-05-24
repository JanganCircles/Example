﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class scEventMain4 : MonoBehaviour, iEvent
{
    public GameObject Mannequin;
    public GameObject pig;
    public GameObject lights;
    public scSound sound;
    public GameObject BGM;
    public GameObject BlackBorad;

    public GameObject Posi; // ? 
    public GameObject Player;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Run()
    {
        StartCoroutine(EventStream());
    }


    IEnumerator EventStream()
    {
        yield return new WaitForSeconds(3f);

        BlackBorad.SetActive(true);
        Debug.Log("마네킹 킴 , 조명 킴 ");
        Mannequin.SetActive(true);
        lights.SetActive(true);

        Debug.Log("조명설정 해야함");

        Debug.Log("비웃음 소리가 들림");
        sound.Run();


        Debug.Log("돼지탈이 마네킹 무리 중앙에 설치");
        pig.SetActive(true);
        

        yield return new WaitForSeconds(2f);
        sound.audioPlayer.Stop();


        


        yield return new WaitForSeconds(3f);
        Mannequin.SetActive(false);

        Debug.Log("조명 꺼짐");
        lights.SetActive(false);



        
        DontDestroyOnLoad(Player);
        DontDestroyOnLoad(BGM);
        //yield return new WaitForSeconds(1f);
        Posi.transform.position = Player.transform.position;
        Posi.transform.rotation = Player.transform.rotation;
            Debug.Log("Player.transform.position" + Player.transform.position);
            Debug.Log("Player.transform.rotation" + Player.transform.rotation);
            Debug.Log("Posi.transform.position" + Posi.transform.position);
            Debug.Log("Posi.transform.rotation" + Posi.transform.rotation);
        SceneManager.LoadScene("EvtShinHyeon");
        Player.GetComponent<scEventMain1>().enabled = false;
        //Player = gameObject.transform.Find("Player").gameObject;
        Player.transform.position = Posi.transform.position;
        Player.transform.rotation = Posi.transform.rotation;
        RenderSettings.ambientSkyColor = new Color(0.1f, 0.1f, 0.1f);
        Debug.Log("7272Player.transform.position" + Player.transform.position);
            Debug.Log("7272Player.transform.rotation" + Player.transform.rotation);
            Debug.Log("7272Posi.transform.position" + Posi.transform.position);
            Debug.Log("7272Posi.transform.rotation" + Posi.transform.rotation);



    }
    public void GetiEvent(object obj) { (obj as scEventRunner).SetUpEvt(this); }

}
