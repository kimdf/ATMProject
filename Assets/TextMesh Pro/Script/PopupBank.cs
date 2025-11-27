using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PopupBank : MonoBehaviour
{
    [Header("팝업 UI")]
    [SerializeField] private GameObject DepositAmount; 
    [SerializeField] private GameObject WithdrawalAmount;
    [SerializeField] private GameObject Deposit;
    [SerializeField] private GameObject Withdrawal;
    [SerializeField] private GameObject popupError;

    [Header("Input")]
    [SerializeField] private TMP_InputField depositAmountinput;
    [SerializeField] private TMP_InputField withdrawalAmountinput;
    public void ShowDepositPopup()
    {
        DepositAmount.SetActive(true);            
        WithdrawalAmount.SetActive(false);
        Deposit.SetActive(false);
        Withdrawal.SetActive(false);
        
    }
    public void ShowWithdrawalPopup()
    {
        WithdrawalAmount.SetActive(true);
        DepositAmount.SetActive(false);
        Deposit.SetActive(false);
        Withdrawal.SetActive(false);

    }
    public void ClosePopup()
    {
        DepositAmount.SetActive(false);
        WithdrawalAmount.SetActive(false);
        Deposit.SetActive(true);
        Withdrawal.SetActive(true);
    }
    public void ShowError(string message)
    {
        popupError.SetActive(true);
    }

    public void OnClickDepositAmount(int amount)
    {
        UserData userData = GameManager.Instance.userData;
        if (userData.cash < amount)
        {           
            return;
        }
        userData.cash -= amount;
        userData.bankcash += amount;
        Debug.Log($"입금 완료! 현금 {userData.cash}, 은행 {userData.bankcash}");

    }

    public void Withdraw(int amount)
    {
        UserData userData = GameManager.Instance.userData;  
        if (userData.cash < amount)
        {
            return;
        }
        userData.bankcash -= amount;
        userData.cash += amount;
        Debug.Log($"현금: {userData.cash:N0}, 은행: {userData.bankcash:N0}");
    }
}
