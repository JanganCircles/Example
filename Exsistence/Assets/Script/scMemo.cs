using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scMemo : MonoBehaviour {
    private string file;
    private string textValue;
    public bool memoState = false;
    private MeshRenderer memoNote;
    // Use this for initialization
    void Start()
    {
        memoNote = gameObject.GetComponentInChildren<MeshRenderer>();
        file = @"C:\Users\admin\Documents\GitHub\Exsistence";
        textValue = System.IO.File.ReadAllText(file);
        print(textValue);
    }
	
	// Update is called once per frame
	void Update () {

        if (memoState != false)
        {
            memoNote.enabled = false;
        }
        else
            memoNote.enabled = true;
        // memoCheck();
    }
  
}
