using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scDoor : MonoBehaviour {
    private bool dOn = false;
    private bool dOff;
    private Transform doorTr;
	// Use this for initialization
	void Start () {
        doorTr= GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
		if (dOn)
        {
            StartCoroutine(open_Door());
            //transform.Rotate(new Vector3(0, 90, 0));
           
                dOn = false;
        }
       /* if (dOff)
        {
            transform.Rotate(new Vector3(0, -90, 0));
            dOff = false;
        }*/
        
	}
    public void Close()
    {
        dOff = true;
    }
    public void Open()
    {
        dOn = true;
    }
    IEnumerator open_Door()
    {
        //
        // {
        while (true)
        {
            if (transform.eulerAngles.y >= 90)
            {

                transform.Rotate(new Vector3(0, 10, 0));

                yield return null;
            }
        }
        }
           
       // }
    }
    

