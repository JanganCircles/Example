using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scEnding03 : MonoBehaviour
{
    public GameObject[] light;
    //[0] : Player, [1] : Point, [2] : 
    public GameObject[] transform;

    private Animator Anim;

    void Start()
    {
        Anim = gameObject.GetComponent<Animator>();
    }
    void Update()
    {
        if (scGameManager.instance.eventIndex == -3)
            Ending();
    }

    void Ending()
    {
        scPlayer.play = false;

        for (int i = 0; i < light.Length; i++)
            light[i].SetActive(false);

        transform[0].transform.LookAt(transform[1].transform);

        

        Anim.SetTrigger("Move");
    }
}
