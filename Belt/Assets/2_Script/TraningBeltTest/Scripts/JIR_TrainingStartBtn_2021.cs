using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JIR_TrainingStartBtn_2021 : MonoBehaviour
{
    public bool isTouch = false;            // 게임이 시작 여부

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.name.Contains("ControllerCollider"))
        {
            // 버튼이 눌러짐을 알림
            isTouch = true;
            gameObject.SetActive(false);
        }
    }
}