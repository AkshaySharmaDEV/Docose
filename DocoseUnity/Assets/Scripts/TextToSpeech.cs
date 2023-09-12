using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextToSpeech : MonoBehaviour
{

    public AudioSource _audio;
    public TMP_Text statustext;

    public TMP_Text GenderText;
    public TMP_Text AgeText;
    public TMP_Text WeightText;
    public TMP_Text HeightText;
    public TMP_Text Langauge;
    // Start is called before the first frame update
    void Start()
    {
        _audio = gameObject.GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator DownloadTheAudio()
    {
        string url = "https://translate.google.com/translate_tts?ie=UTF-8&total=1&idx=0&textlen=32&client=tw-ob&q="+statustext.text+"&tl=En-"+Langauge.text;
        WWW www = new WWW (url);
        yield return www;

        _audio.clip = www.GetAudioClip (false, true, AudioType.MPEG);
        _audio.Play();
    }
    public void ButtonClick(){
        StartCoroutine (DownloadTheAudio());
    }

    public void Gender()
    {
        statustext.text = GenderText.text;
        StartCoroutine (DownloadTheAudio());
    }

    public void Age()
    {
        statustext.text = AgeText.text;
        StartCoroutine (DownloadTheAudio());
    }

    public void Weight()
    {
        statustext.text = WeightText.text;
        StartCoroutine (DownloadTheAudio());
    }

    public void Height()
    {
        statustext.text = HeightText.text;
        StartCoroutine (DownloadTheAudio());
    }
}
