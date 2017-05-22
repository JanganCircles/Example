using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scDoor : MonoBehaviour
{
    private bool dOn = true;
        
    private Animator doorAni;
    public GameObject Door;
    
    void Start()
    {
       
        doorAni = Door.GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
      

    }
   
    public void Open()
    {
        
        doorAni.SetBool("doorState", dOn);
       
        dOn = !dOn;
    }



}

    

