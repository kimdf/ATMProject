using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// NPC 상호작용 관련 플레이어 탐지 클래스
public class PlayerDetectionTrigger : MonoBehaviour
{
    private TopDownController controler;
    [SerializeField] private RectTransform interactionIcon; 
    [SerializeField] private Vector3 interactionIconPosition; 

    private bool isPlayerInside = true; 
    private void Start()
    {
      
    }

    private void OnTriggerEnter2D(Collider2D collision) // NPC 상호작용 활성화
    {
        if (!collision.CompareTag("Player")) // 플레이어가 아니라면 return
        {
            return;
        }

        isPlayerInside = true;
        StartCoroutine(InteractionIconPositionUpdater());
        interactionIcon.gameObject.SetActive(true);

    }
    private void OnTriggerExit2D(Collider2D collision) // NPC 상호작용 비활성화
    {
        if (!collision.CompareTag("Player")) // 플레이어가 아니라면 return
        {
            return;
        }

        isPlayerInside = false;
        interactionIcon.gameObject.SetActive(false);
    }

    private IEnumerator InteractionIconPositionUpdater() // 상호작용 UI 위치를 NPC 옆에 표시
    {
        while (isPlayerInside)
        {
            Vector3 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
            interactionIcon.position = screenPosition + interactionIconPosition;

            yield return null;
        }
    }
}