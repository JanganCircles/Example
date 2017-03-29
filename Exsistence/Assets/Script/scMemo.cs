using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scMemo : MonoBehaviour {
    private string file;
    private string textValue;
    public bool memoState = false;
    public MeshRenderer memoNote;
    // Use this for initialization
    void Start()
    {
        memoNote = gameObject.GetComponent<MeshRenderer>();
         file = @"C:\Users\admin\Documents\GitHub\Exsistence";
         textValue = System.IO.File.ReadAllText(file);
    }
	
	// Update is called once per frame
	void Update () {
        print(textValue);
        if (memoState != false)
        {
            memoNote.enabled = false;
        }
        // memoCheck();
    }
    void memoCheck()
    {
        if(memoState != false)
        {
            memoNote.enabled = false;
        }
    }
}
