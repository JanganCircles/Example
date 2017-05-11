using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scMsg : MonoBehaviour {
    private static List<GameObject> msgList = new List<GameObject>();
    public static GameObject msgText;
	// Use this for initialization
	void Start () {
        //msgList = null;
        msgText = transform.GetChild(0).gameObject;
        CreateNewMessage("안녕");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public static void CreateNewMessage(string str) { 
        msgList.Add(Instantiate(msgText));
        msgList[0].GetComponent<Transform>().GetComponent<Text>().text = str;
    }
    public static void DeleteMessage(int index) {
        msgList.RemoveAt(index);
    }
    public static void DeleteMessage(string TextValue) {
        msgList.Remove(msgList.Find(msgList => msgList.name.Contains("TextValue")));
    }


}
