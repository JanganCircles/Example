using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scSceneMove : MonoBehaviour
{
    //누른 버튼의 이름을 미리 받아옴
    public string buttonName;

    public static bool EnableCreateMenu = true;

    public void MoveScene()
    {

        //버튼의 이름을 아래 케이스들과 비교
        switch (buttonName)
        {
            //버튼의 이름이 main이거나 title이면 buttonName의 씬으로 이동
            case "main":
            case "title":
                EnableCreateMenu = true;
                scPlayer.play = true;

                SceneManager.LoadScene(buttonName);
                break;

            case "loadGame":
                break;

            //버튼의 이름이 leaveGame이면 게임 종료
            case "leaveGame":
                //SceneManager의 게임 종료를 몰라서 구형식으로 작성함.
                Application.Quit();
                break;

            //버튼의 이름이 setting이면 리소스 폴더에있는 UI를 가져와서 Instantiate함
            case "setting":
                GameObject canvas = Resources.Load("Prefabs/SettingCanvas") as GameObject;
                Instantiate(canvas, new Vector3(0,0,0), Quaternion.identity);
                break;

            //버튼의 이름이 Back이면 자신의 부모 객체삭제
            case "back":
                Destroy(this.transform.parent.gameObject);
                break;

            //아무 버튼도 아닐 시 에러 출력
            default:
                Debug.Log(buttonName + "은 지정되지 않은 버튼 / Unspecified button.");
                break;
        }
    }
}
