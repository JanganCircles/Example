using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scEventMain4 : MonoBehaviour, iEvent
{
    public GameObject Mannequin;
    public GameObject pig;
    public GameObject lights;
    scSound sound;
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
    /*public void CreateMannequin() // 마네킹 생성 
    {
        for (int i = 0; i < pos.Length; i++)
            Instantiate(Mannequin[i], pos[i].transform);
    }*/

    IEnumerator EventStream()
    {
        Debug.Log("마네킹 킴");
        Mannequin.SetActive(true);


        Debug.Log("조명설정 해야함");

        Debug.Log("비웃음 소리가 들림");
        sound.Run();


        Debug.Log("돼지탈이 마네킹 무리 중앙에 설치");
        pig.SetActive(true);
        

        yield return new WaitForSeconds(2f);
        Mannequin.SetActive(false);


        yield return new WaitForSeconds(3f);
        Debug.Log("조명 꺼짐");
        lights.SetActive(false);

        

    }
    public void GetiEvent(object obj) { (obj as scEventRunner).SetUpEvt(this); }

}
