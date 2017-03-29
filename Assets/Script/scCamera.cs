using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scCamera : MonoBehaviour {
    private Transform tr;
    public float rotSpeed = 100.0f;
    // Use this for initialization
    void Start () {
        tr = GetComponent<Transform>();
    }
	
	// Update is called once per frame
	void Update () {
        //Debug.Log("tr.rotation.x: "+ tr.rotation.x);
        /*Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        
        if (Physics.Raycast(ray, out hit, Mathf.Infinity))
        {
            Debug.Log(hit.collider.gameObject.name);
            Debug.DrawLine(ray.origin, hit.point);
            if (hit.collider.tag == "phone")
                Cursor.visible = true;

        }*/
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
}
