using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class InteractionTrigger : MonoBehaviour
{
    // 플레이어가 트리거에 들어왔을 때 실행되는 함수
    public GameObject interactionPopup;  // 상호작용 안내 UI (에디터에서 연결)

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            interactionPopup.SetActive(true); // 플레이어가 접근하면 팝업 표시
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            interactionPopup.SetActive(false); // 플레이어가 벗어나면 팝업 숨김
        }
    }

}