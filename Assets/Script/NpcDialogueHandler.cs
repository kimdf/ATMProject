using UnityEngine;
using TMPro;
using System;

public class NpcDialogueHandler : MonoBehaviour
{
    [SerializeField] private DialogueData dialogueData; // NPC 대화 정보
    [SerializeField] private GameObject dialougeUI; // 대화 창 UI
    [SerializeField] private TextMeshProUGUI dialougeText; // 대화 창 UI

    public object EntityDataManager { get; private set; }

    public void DialogueEvent() // 대화 이벤트
    {
        if (dialogueData.DialogueComplete()) // 대화가 끝났는지 확인
        {
            // 끝났다면 대화 종료 및 초기화
            ControlDialogueInterface(false);
            dialogueData.ResetDialogue();
            return;
        }

        if (!dialougeUI.gameObject.activeSelf) // 대화 창이 켜져있지 않다면 대화 시작
        {
            ControlDialogueInterface(true);
        }

        //// 대화 창 텍스트에 대화 저장
        //string playerName = EntityDataManager.Instance.PlayerData.Name;
        //text.Replace("\'@\'", $"\'{playerName}\'"); // Player 이름 치환
        //dialougeText.text = dialogueData.GetDialogue();
    }

    private void ControlDialogueInterface(bool isTrue) // 대화 창 활성화/비활성화
    {
        dialougeUI.gameObject.SetActive(isTrue);
    }
}

internal class DialogueData
{
    internal bool DialogueComplete()
    {
        throw new NotImplementedException();
    }

    internal string GetDialogue()
    {
        throw new NotImplementedException();
    }

    internal void ResetDialogue()
    {
        throw new NotImplementedException();
    }
}