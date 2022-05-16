using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class BuildingScript : MonoBehaviour, IPointerClickHandler
{
    [SerializeField]
    private Building building;

    public int myMoney;

    public int nowMoney;

    public Text myMoneyText;
    public Text nowMoneyText;

    private void OnEnable()
    {
        StartCoroutine(PlusMoney(1));
    }

    // Update is called once per frame
    void Update()
    {
        myMoneyText.text = myMoney.ToString();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (nowMoney != 0)
        {
            AudioManager.instnace.PlusMoneySound();
            nowMoneyText.text = "+" + nowMoney.ToString();
            UIManager.instance.PlusMoney();
            myMoney += nowMoney;
            nowMoney = 0;
            if (myMoney == 500)
            {
                StartCoroutine(PlusMoney(1));
            }
        }
    }

    IEnumerator PlusMoney(float delayTime)
    {
        yield return new WaitForSeconds(delayTime);
        nowMoney += building.PlusMoney;
        if(nowMoney < 500)
        {
            StartCoroutine(PlusMoney(1));
        }
        else if(nowMoney >= 500)
        {
            StopCoroutine(PlusMoney(1));
        }
    }


}
