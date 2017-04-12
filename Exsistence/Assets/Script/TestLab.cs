using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Use this for initialization
//----------------안녕하세요 TestLab에 오신걸 환영합니다!!!!---------------------------------//
//**********************이곳에서 별의 별 실험을 하십시오!!!**********************************//
public class TestLab : MonoBehaviour
{


    private Color _fadeColor;

    public SpriteRenderer _fadeImage;
    public float _fadeTime;
    public float _waitTime;
    public bool _isLoadScene;
    public FadeSetting _fadeSetting;
    public string _loadSceneName = null;

    void Start()
    {
        _fadeColor = new Color(0f, 0f, 0f, 1f);
        _fadeImage.color = _fadeColor;
        if (_fadeSetting._fadeIn)
            StartCoroutine(FadeIn());
    }

    IEnumerator FadeIn()
    {
        float elapsedTime = 0f;

        while (elapsedTime < _fadeTime)
        {
            yield return new WaitForEndOfFrame();
            elapsedTime += Time.deltaTime;
            _fadeColor.a = 1.0f - Mathf.Clamp01(elapsedTime / _fadeTime);
            _fadeImage.color = _fadeColor;
        }
        if (_fadeSetting._fadeOut)
            StartCoroutine(FadeOut());
    }

    IEnumerator FadeOut()
    {
        float elapsedTime = 0f;

        yield return new WaitForSeconds(_waitTime);

        while (elapsedTime < _fadeTime)
        {
            yield return new WaitForEndOfFrame();
            elapsedTime += Time.deltaTime;
            _fadeColor.a = Mathf.Clamp01(elapsedTime / _fadeTime);
            _fadeImage.color = _fadeColor;
        }

        if (_isLoadScene)
        {
            if (_loadSceneName != null)
               
        }
    }
}

