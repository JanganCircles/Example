using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scMemo : MonoBehaviour {
    private string file;
    private string textValue;
    // Use this for initialization
    void Start()
    {

         file = @"C:\Users\admin\Documents\GitHub\Exsistence-master(1)\Exsistence-master";
         textValue = System.IO.File.ReadAllText(file);
    }
	
	// Update is called once per frame
	void Update () {
        print(textValue);
	}
}
