using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scEnding01 : MonoBehaviour
{
    //Object[0] : Door, [1] : Camera
    public GameObject[] Object;
    public AudioClip audioclip;

    private AudioSource audio;
    private int count = 0;

	void Update ()
    {
        if(scGameManager.instance.eventIndex == -1)
        {
            scPlayer.play = false;

            if(count == 0)
            {
                count++;

                Object[1].transform.LookAt(Object[0].transform);

                Ending();
                OpenDoor();
            }
        }    
    }

    void Ending()
    {
        float distance = 0;
        distance = Vector3.Distance(Object[0].transform.position, Object[1].transform.position);

        if (distance >= 0.5)
            transform.position = Vector3.forward;
    }

    void OpenDoor()
    {
        audio.clip = audioclip;
        Object[0].SendMessage("Open", SendMessageOptions.DontRequireReceiver);
        audio.Play();
    }
}
