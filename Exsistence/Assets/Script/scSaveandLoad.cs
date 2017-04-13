using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using System.IO;

public class scSaveandLoad : MonoBehaviour
{
    string dir;
    string fileName;

    void Awake()
    {
        dir = Application.dataPath + "/Resources/Save";
        fileName = dir + "/Save File" + this.gameObject.name.Substring(8) + ".txt";
    }

    public void Save()
    {
        StreamWriter stream = new StreamWriter(@fileName);
        scGameManager instance = new scGameManager();

        if (GameObject.Find("Player"))
        {
            Transform TPlayer = GameObject.Find("Player").transform;

            stream.WriteLine(Application.loadedLevelName);
            stream.WriteLine(TPlayer.position);
            stream.WriteLine(TPlayer.rotation);
            stream.WriteLine(instance.eventIndex);

            stream.Flush();
            stream.Close();
        }
    }
}
