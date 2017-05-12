using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scMsg : MonoBehaviour {
    private static List<GameObject> msgList = new List<GameObject>();
    public static GameObject msgCanvas;
	// Use this for initialization
	void Start () {
        //msgList = null;
        msgCanvas = GameObject.FindWithTag("msgCanvas");
        if (msgCanvas != null)
        {
            Debug.Log("아아아아");
            CreateNewMessage("안녕");
            CreateNewMessage("지현아");
            CreateNewMessage("지현우주");
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public static void CreateNewMessage(string str) { 
        msgList.Add(Instantiate(msgCanvas));
        msgList[msgList.Count-1].transform.GetChild(0).GetChild(0)
            .GetComponent<Transform>().GetComponent<Text>().text = str;
       // ReMessage();
    }
    public static void DeleteMessage(int index) {
        msgList.RemoveAt(index);
        ReMessage();
    }
    public static void DeleteMessage(string TextValue) {
        msgList.Remove(msgList.Find(msgList => msgList.name.Contains("TextValue")));
        ReMessage();
    }
    public static void ReMessage()
    {
        for (int i = 0; i < msgList.Count; i++) {
            msgList[i].GetComponent<Transform>()
                .GetComponent<RectTransform>().Translate(new Vector3(193, 70-(i*40), 0));
        }
    }
    public static void MessageVis()
    {
        for (int i = 0; i < msgList.Count; i++)
        {
            msgList[i].SetActive(true);
        }
    }
    public static void MessageUnvis()
    {
        for (int i = 0; i < msgList.Count; i++)
        {
            msgList[i].SetActive(false);
        }
    }

}
