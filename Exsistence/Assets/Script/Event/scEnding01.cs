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

    void Start()
    {
        audio = transform.GetComponent<AudioSource>();
    }
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
        GameObject Player = Object[0].transform.parent.gameObject;

        float distance = 0;
        float i = 0;

        distance = Vector3.Distance(Object[0].transform.position, Object[1].transform.position);

        if (distance >= 0.5)
           Player.transform.position = new Vector3(Player.transform.position.x + i++,0,Player.transform.position.z + i++);
    }

    void OpenDoor()
    {
        audio.clip = audioclip;
        Object[0].SendMessage("Open", SendMessageOptions.DontRequireReceiver);
        audio.Play();
    }
}
