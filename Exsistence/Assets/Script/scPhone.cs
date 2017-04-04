using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class scPhone : MonoBehaviour, IPointerEnterHandler,IPointerExitHandler
{
    public static bool play = true;
    private int iphone = 0;
    GameObject phone;
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
        phone = transform.Find("Phone").gameObject;
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Tab)){
            if (iphone == 0)
            { phone.SetActiveRecursively(true); iphone = 1; }
            else
            { phone.SetActiveRecursively(false); iphone = 0; }
        }
        
    }
}
