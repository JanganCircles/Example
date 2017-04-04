using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scPlayer : MonoBehaviour {
    public static bool play = true;

	private float h = 0.0f;
	private float v = 0.0f;
	public float moveSpeed = 10.0f;
	public float rotSpeed = 100.0f;
    private Vector3 moveDirection = Vector3.zero;
    //private int iflashlight = 0;
    public GameObject PauseCanvas;
    GameObject flashlight;
    CharacterController controller;
    private Transform tr;

    // Use this for initialization
    void Start () {
		tr = GetComponent<Transform>();
        
        //flashlight = transform.Find("flashlight").gameObject;
    }
	
	// Update is called once per frame
	void Update () {
        controller = GetComponent<CharacterController>();
        if (play)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= moveSpeed;
            controller.Move(moveDirection * Time.deltaTime);
            if (scPhone.play) tr.Rotate(Vector3.up * Time.deltaTime * rotSpeed * Input.GetAxis("Mouse X"));
            
        }


        if (Input.GetKeyDown(KeyCode.Escape) && scSceneMove.EnableCreateMenu)
        {
            scSceneMove.EnableCreateMenu = false;
            play = false;

            PauseCanvas.SetActive(true);
        }
        else if(Input.GetKeyDown(KeyCode.Escape) && !scSceneMove.EnableCreateMenu)
        {
            if(GameObject.Find("SettingCanvas"))
            {
                scSceneMove.SettingCanvas.SetActive(false); ;
            }
            else
            {
                scSceneMove.EnableCreateMenu = true;
                play = true;

                PauseCanvas.SetActive(false);
            }
        }
    }
}
