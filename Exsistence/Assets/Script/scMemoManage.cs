using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class scMemoManage : MonoBehaviour {
    public static scMemoManage instance;
    List<string> list = new List<string>();
    // Use this for initialization
    void Awake()
    {
       scMemoManage.instance = this;   
    }
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void StringLoad()
    {
        //list.Add();
    }
}
