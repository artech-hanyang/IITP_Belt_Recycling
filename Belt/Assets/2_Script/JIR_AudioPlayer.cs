using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JIR_AudioPlayer : MonoBehaviour
{
    public AudioSource beltPlayer;        // 버튼이 눌려졌을 때의 소리 재생기
    public AudioClip startAudioClip;      // 버튼이 눌려졌을 때의 소리와 컨베이어 Belt 작동 소리 파일

    public float beltSoundTimer = 1.0f;
    JIR_TrainingStartBtn ir_startBtn;

    private void Awake()
    {
        beltPlayer = GetComponent<AudioSource>();
        ir_startBtn = GameObject.Find("pCylinder96 3").GetComponent<JIR_TrainingStartBtn>();
    }

    // Update is called once per frame
    void Update()
    {
        beltPlayer.clip = startAudioClip;

        if (ir_startBtn.isTouch == true)
        {
            beltPlayer.Play();
            beltPlayer.PlayDelayed(beltSoundTimer);
            beltPlayer.loop = true;
        }
    }
}
