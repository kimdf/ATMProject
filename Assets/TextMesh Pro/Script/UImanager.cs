using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class UImanager : MonoBehaviour
{
    [Header("메인")]
    [SerializeField] private TMP_Text playername;
    [SerializeField] private TMP_Text Bankcash;
    [SerializeField] private TMP_Text cash;

    [Header("버튼")]
    [SerializeField] private GameObject withdrawal;
    [SerializeField] private GameObject deposit;


    public void Refresh()
    {
        playername.SetText(GameManager.Instance.userData.userName);
        Bankcash.SetText(GameManager.Instance.userData.bankcash.ToString());
        cash.SetText(GameManager.Instance.userData.cash.ToString());
    }
   
   
    public void Start()
    {
        Refresh();
    }
}