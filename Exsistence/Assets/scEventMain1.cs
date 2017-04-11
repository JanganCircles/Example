using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scEventMain1 : MonoBehaviour {
    public GameObject gameobj;
    public SpriteRenderer blackFade;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update()
    {

    }

    void EVT()
    {
        gameobj.SetActive(false);
    }
    IEnumerator FadeIn()
    {
        for (float i = 1f; i >= 0;i-=0.1f)
        {
            Color color = new Vector4(1, 1, 1, i);
            blackFade.color = color;

            yield return new WaitForSeconds(1f);
        }
    }


    


}
