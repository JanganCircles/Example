using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class scPhone : MonoBehaviour, IPointerEnterHandler,IPointerExitHandler
{
    public static bool play = true;

    public void OnPointerEnter(PointerEventData data)
    {
        Debug.Log("MouseOver");
        play = false;
        Cursor.visible = true;
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        Cursor.visible = false;
        play = true;
    }

    // Use this for initialization
    void Start () {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update() {

    }
}
