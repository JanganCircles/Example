using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 박세찬
public class scEventSound : MonoBehaviour, iEvent
{
    
    public scRunner Runner;
    public AudioSource audioPlayer; // 음악 플레이어 
    public AudioClip SoundClip; // 실제 음악 파일 
    //public string soundName = null; //?
    
    
   
    [Range(0f, 1f)]
    public float soundVolume=1f; // 음악 불륨 
   

    
    public bool loopSet; //몇 번 루프할건지(혹은 무한), 얼마나 지속되는지
    public bool rangeSeting; // 이거 체크하면 게임안에서 크기 변경 가능함 

    [Range(0f, 15f)]
    public float soundMinDistance;
    [Range(15f, 30f)]
    public float soundMaxDistance;


    // Use this for initialization
    void Awake () {
        Runner.SetEvent(this);

        audioPlayer = gameObject.AddComponent<AudioSource>();
        audioPlayer.clip = SoundClip;
        
         soundSet();
         


    }
	
	// Update is called once per frame
	void Update () {
        if (rangeSeting == true)
        {
            soundSet();// 계속 값 바꾸고 싶어서 update에 놓음 
        }
        
    }

    public void soundSet() // 소리 들리는 범위 설정 함수 
    {
        audioPlayer.minDistance = soundMinDistance;
        audioPlayer.maxDistance = soundMaxDistance;
        audioPlayer.loop = loopSet;
        audioPlayer.volume = soundVolume;
    }

    public void Run()
    {
        audioPlayer.PlayOneShot(SoundClip);
        //^ StartCoroutine(play());
    }

    IEnumerator play() // ?$
    {
        audioPlayer.PlayOneShot(SoundClip);
        yield return new WaitForSeconds(0.3f);
    }
}
