using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using System.IO;

public class scSaveandLoad : MonoBehaviour
{
    GameObject TPlayer;

    public void Awake()
    {
        
    }
    public void Save()
    {
        TPlayer = GameObject.Find("Player");

        string dir = Application.dataPath + "/Resources/Save";
        string fileName = dir + "/Save File" + this.gameObject.name.Substring(8) + ".txt";

        StreamWriter stream = new StreamWriter(@fileName);
        scGameManager instance = new scGameManager();

        if (GameObject.Find("Player"))
        {
            

            stream.WriteLine(Application.loadedLevelName);
            stream.WriteLine(TPlayer.transform.position);
            stream.WriteLine(TPlayer.transform.rotation);
            stream.WriteLine(instance.eventIndex);

            stream.Flush();
            stream.Close();
        }
    }

    public void Load()
    { 
        scGameManager instance = new scGameManager();

        string dir = Application.dataPath + "/Resources/Save";
        string fileName = dir + "/Save File" + this.gameObject.name.Substring(8) + ".txt";

        FileStream Fs = new FileStream(fileName, FileMode.Open);
        StreamReader Stream = new StreamReader(Fs);

        SceneManager.LoadScene(Stream.ReadLine());

        TPlayer = GameObject.Find("Player");
        
        Debug.Log(TPlayer.name);

        string[] reCharP = Stream.ReadLine().Trim('(', ')').Split(',');
        string[] reCharR = Stream.ReadLine().Trim('(', ')').Split(',');
        
        TPlayer.transform.position
            = new Vector3(float.Parse(reCharP[0]), float.Parse(reCharP[1]), float.Parse(reCharP[2]));
        TPlayer.transform.rotation
            = new Quaternion(float.Parse(reCharR[0]), float.Parse(reCharR[1]), float.Parse(reCharR[2]), float.Parse(reCharR[3]));

        instance.eventIndex = int.Parse(Stream.ReadLine());

        Stream.Close();
    }
}

