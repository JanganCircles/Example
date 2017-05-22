using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class scEvt9th : MonoBehaviour, iEvent
{
    public GameObject Locker;
    public GameObject ShockBox;
    public GameObject Bag;


    public GameObject Posi; // ? 
    public GameObject Player;


    public void GetiEvent(object obj) { (obj as scEventRunner).SetUpEvt(this); }

    public void Run()
    {
        Locker.GetComponent<scSetBool>().isLock = false;
        ShockBox.SetActive(true);
        Bag.SetActive(true);




        DontDestroyOnLoad(Player);
        Posi.transform.position = Player.transform.position;
        Posi.transform.rotation = Player.transform.rotation;
        Debug.Log("Player.transform.position" + Player.transform.position);
        Debug.Log("Player.transform.rotation" + Player.transform.rotation);
        Debug.Log("Posi.transform.position" + Posi.transform.position);
        Debug.Log("Posi.transform.rotation" + Posi.transform.rotation);
        SceneManager.LoadScene("EvtShinHyeon");
        //Player = gameObject.transform.Find("Player").gameObject;
        Player.transform.position = Posi.transform.position;
        Player.transform.rotation = Posi.transform.rotation;

        Debug.Log("7272Player.transform.position" + Player.transform.position);
        Debug.Log("7272Player.transform.rotation" + Player.transform.rotation);
        Debug.Log("7272Posi.transform.position" + Posi.transform.position);
        Debug.Log("7272Posi.transform.rotation" + Posi.transform.rotation);

    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
