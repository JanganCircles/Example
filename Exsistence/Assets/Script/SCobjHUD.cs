using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SCobjHUD : MonoBehaviour {
    public TextMesh hudText;                // 텍스트
    private float objside;                  // 거리 계산
    public bool interaction = false;        // 상호작용 on/off
    private Transform interactionTr;        // 상호작용 받는 것의 위치 값 받아오는 변수
    private Transform playerTr;             // 플레이어의 위치 값을 받아오는 변수
    private MeshRenderer interactionMesh;   // 상호작용이 되면 Meshrenderer on
    private CapsuleCollider playerRd;       // collider radius 값과 거리를 같게 해줄 변수
    public Transform target;
	// Use this for initialization
	void Start () {
        interactionTr = GameObject.Find("interaction").transform;
        playerTr = GameObject.Find("Sphere").transform;
        interactionMesh = GameObject.Find("interaction").GetComponent<MeshRenderer>();
        interactionMesh.enabled = false;
        playerRd = GameObject.Find("Capsule").GetComponent<CapsuleCollider>();
        objside = playerRd.radius;
        
    }

    // Update is called once per frame
    void Update() {
        float distance = Vector3.Distance(interactionTr.position, transform.position);
        if (distance <= objside)
        {
            interactionMesh.enabled = true;
            if (interaction != false)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    print("e눌림");
                }
            }
        }
        else
        {
            interactionMesh.enabled = false;
        }
            }
}
