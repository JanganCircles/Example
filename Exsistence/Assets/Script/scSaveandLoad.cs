using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using System.IO;

public class scSaveandLoad : MonoBehaviour
{   
    public void Save()
    {
        string fileName = "Save File " + this.gameObject.name.Substring(9);

        StreamWriter stream = new StreamWriter(fileName);

        if (GameObject.Find("Player"))
        {
            Transform TPlayer = GameObject.Find("Player").transform;
            stream.WriteLine(Application.loadedLevelName);
            stream.WriteLine(TPlayer);
            stream.WriteLine(scGameManager.instance.eventIndex);

            Debug.Log("Scene Name : " + Application.loadedLevelName + ", Player Transform" + TPlayer.position + ", Event Index" + scGameManager.instance.eventIndex);
        }
    }
}
