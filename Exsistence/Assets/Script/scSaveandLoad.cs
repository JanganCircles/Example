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
        TPlayer = GameObject.Find("Player");
    }
    public void Save()
    {
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
        string dir = Application.dataPath + "/Resources/Save";
        string fileName = dir + ".Save File" + this.gameObject.name.Substring(8) + ".txt";

        string num = null;
        float[] PNum = { };

        FileStream Fs = new FileStream(fileName, FileMode.Open);
        StreamReader Stream = new StreamReader(Fs);

        SceneManager.LoadScene(Stream.ReadLine());
        foreach (char ch in Stream.ReadLine())
        {
            int i = 0;

            if(ch != '(' || ch != ')')
            {
                if (ch != ',')
                {
                    num += ch;
                }
                else
                {
                    PNum[i] = float.Parse(num);
                    i++;
                }
            }
        }

        
    }
}

