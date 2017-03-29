using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scCamera : MonoBehaviour {
    private Transform tr;
    public float rotSpeed = 100.0f;
    Vector3 cameraPos;
    // Use this for initialization
    void Start () {
        tr = GetComponent<Transform>();
    }
	
	// Update is called once per frame
	void Update () {
        if (scPlayer.play && scPhone.play)
        {
            if (tr.rotation.x <= 0.45f && tr.rotation.x >= -0.45f)
            {
                tr.Rotate(Vector3.left * Time.deltaTime * rotSpeed * Input.GetAxis("Mouse Y")); //x -45~45
            }
            else if (tr.rotation.x > 0.45f) tr.rotation = Quaternion.Euler(45, 0, 0);
            else tr.rotation = Quaternion.Euler(-45, 0, 0);
        }
    }
    void FixCameera() {
        cameraPos = new Vector3(tr.position.x,tr.position.y,tr.position.z);
    }
    void backCamera() {
        tr.Translate(cameraPos);
    }
}
