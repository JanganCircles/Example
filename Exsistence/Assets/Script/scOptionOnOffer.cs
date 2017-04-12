using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scOptionOnOffer : MonoBehaviour
{

    public GameObject PauseCanvas;
    public GameObject SaveCanvas;

    public static GameObject PSaveCanvas;

    private void Start()
    {
        PSaveCanvas = SaveCanvas;
    }


    void Update ()
    {
        OnOffer();
	}

    void OnOffer()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && scSceneMove.EnableCreateMenu)
        {
            scSceneMove.EnableCreateMenu = false;
            scPlayer.play = false;

            PauseCanvas.SetActive(true);
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && !scSceneMove.EnableCreateMenu)
        {
            if (GameObject.Find("SaveCanvas"))
            {
                SaveCanvas.SetActive(false);
            }
            else if (GameObject.Find("SettingCanvas"))
            {
                scSceneMove.SettingCanvas.SetActive(false); ;
            }
            else
            {
                scSceneMove.EnableCreateMenu = true;
                scPlayer.play = true;

                PauseCanvas.SetActive(false);
            }
        }
    }
}
