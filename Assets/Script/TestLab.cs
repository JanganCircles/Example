using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Use this for initialization
//----------------안녕하세요 TestLab에 오신걸 환영합니다!!!!---------------------------------//
//**********************이곳에서 별의 별 실험을 하십시오!!!**********************************//
public class TestLab : MonoBehaviour {
    
    
        public Transform startMarker; // 
        public Transform endMarker;
        public float speed = 1.0F;
        private float startTime;
        private float journeyLength;


        void Start()
        {
            startTime = Time.time;
            journeyLength = Vector3.Distance(startMarker.position, endMarker.position); // 두사이간의 거리 
        }   // 이동거리

        void Update()
        {

            float distCovered = (Time.time - startTime) * speed; // 속도관련 

            float fracJourney = distCovered / journeyLength; // 시간 구하는 값 T 분수여야 0~1이니까 분수값으로 


            transform.position = Vector3.Lerp(startMarker.position, endMarker.position, fracJourney);
            //스타트 값       //엔드 좌표값  //T값 

        }
    }


