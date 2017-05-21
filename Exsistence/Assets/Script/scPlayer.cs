﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scPlayer : MonoBehaviour {
    public static bool play = true;

	private float h = 0.0f;
	private float v = 0.0f;
    public float gravity = 30.0f;
    public float moveSpeed = 10.0f;
	public float rotSpeed = 100.0f;

    private Vector3 moveDirection = Vector3.zero;
    //private int iflashlight = 0;

    GameObject flashlight;

    CharacterController controller;
    private Transform tr;

    public struct PlayerTransform
    {
        public static Vector3 PP;
        public static Quaternion PR;
    };
    // Use this for initialization

    void Start () {
        play = true;

        tr = GetComponent<Transform>();

        if(scSaveandLoad.isLoad == true)
        {
            tr.position = PlayerTransform.PP;
            tr.rotation = PlayerTransform.PR;

            scSaveandLoad.isLoad = false;
        }

        //flashlight = transform.Find("flashlight").gameObject;
    }
	
	// Update is called once per frame
	void Update () {
        controller = GetComponent<CharacterController>();
        if (play)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            Quaternion.LookRotation(moveDirection);
            moveDirection *= moveSpeed;
            moveDirection.y -= gravity * Time.deltaTime;
            controller.Move(moveDirection * Time.deltaTime);
            if (scPhone.play) tr.Rotate(Vector3.up * Time.deltaTime * rotSpeed * Input.GetAxis("Mouse X"));
            
        }
        
    }
}
