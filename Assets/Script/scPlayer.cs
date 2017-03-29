using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scPlayer : MonoBehaviour {
    public static bool play = true;
	private float h = 0.0f;
	private float v = 0.0f;
	private Transform tr;
	public float moveSpeed = 10.0f;
	public float rotSpeed = 100.0f;
    GameObject flashlight;
    private int iflashlight = 0;
  
    // Use this for initialization
    void Start () {
		tr = GetComponent<Transform>();
        flashlight = transform.Find("flashlight").gameObject;
    }
	
	// Update is called once per frame
	void Update () {
                
        if (play)
        {
            h = Input.GetAxis("Horizontal");
            v = Input.GetAxis("Vertical");
            Vector3 moveDir = (Vector3.forward * v) + (Vector3.right * h);
            tr.Translate(moveDir * Time.deltaTime * moveSpeed, Space.Self);
            if(scPhone.play) tr.Rotate(Vector3.up * Time.deltaTime * rotSpeed * Input.GetAxis("Mouse X"));
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                if (iflashlight == 0)
                { flashlight.SetActiveRecursively(true); iflashlight = 1; }
                else
                { flashlight.SetActiveRecursively(false); iflashlight = 0; }
            }
        }

        if (Input.GetKeyDown(KeyCode.Escape) && scSceneMove.EnableCreateMenu)
        {
            scSceneMove.EnableCreateMenu = false;
            play = false;

            GameObject canvas = Resources.Load("Prefabs/PauseCanvas") as GameObject;
            Instantiate(canvas, new Vector3(0, 0, 0), Quaternion.identity);
        }
        else if(Input.GetKeyDown(KeyCode.Escape) && !scSceneMove.EnableCreateMenu)
        {
            if(GameObject.Find("SettingCanvas(Clone)"))
            {
                Destroy(GameObject.Find("SettingCanvas(Clone)"));
            }
            else
            {
                scSceneMove.EnableCreateMenu = true;
                play = true;
                Destroy(GameObject.Find("PauseCanvas(Clone)"));
            }
        }
    }
}
