using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class AutoBuildingScript : MonoBehaviour
{
    [SerializeField]
    private Building building;

    public int nowMoney;

    public Text myMoneyText;
    public Text nowMoneyText;
    private bool isRestart;

    public GameObject moneyPlusPanel;

    public Vector2 startPosition;

    private void OnEnable()
    {
        StartCoroutine(PlusMoney(1));
        moneyPlusPanel = gameObject.transform.GetChild(0).gameObject;
        startPosition = gameObject.transform.position;
        nowMoneyText = gameObject.transform.GetChild(0).GetChild(0).GetComponent<Text>();
    }

    void Update()
    {
        myMoneyText.text = UIManager.instance.myMoney.ToString();
        switch (building.BuildingType)  
        {
            case Building.buildingType.House:
                if (isRestart == false)
                {
                    if (nowMoney == 300)
                    {
                        nowMoneyText.text = "+300";
                        GetMoney();
                        UIManager.instance.myMoney += nowMoney;
                        nowMoney = 0;
                        StartCoroutine(PlusMoney(1));
                        isRestart = true;
                    }
                }
                break;
            case Building.buildingType.Building:
                if (isRestart == false)
                {
                    if (nowMoney == 500)
                    {
                        nowMoneyText.text = "+500";
                        GetMoney();
                        UIManager.instance.myMoney += nowMoney;
                        nowMoney = 0;
                        StartCoroutine(PlusMoney(1));
                        isRestart = true;
                    }
                }
                break;
            case Building.buildingType.Hotel:
                if (isRestart == false)
                {
                    if (nowMoney == 1000)
                    {
                        nowMoneyText.text = "+1000";
                        GetMoney();
                        UIManager.instance.myMoney += nowMoney;
                        nowMoney = 0;
                        StartCoroutine(PlusMoney(1));
                        isRestart = true;
                    }
                }
                break;
            default:
                break;
        }
    }

    public void GetMoney()
    {
        AudioManager.instnace.PlusMoneySound();
        moneyPlusPanel.SetActive(true);
        moneyPlusPanel.transform.DOLocalMoveY(320f, 0.5f).OnComplete(() => { moneyPlusPanel.SetActive(false); });
        moneyPlusPanel.transform.localPosition = startPosition;
    }

    IEnumerator PlusMoney(float delayTime)
    {
        yield return new WaitForSeconds(delayTime);
        nowMoney += building.PlusMoney;
        switch (building.BuildingType)
        {
            case Building.buildingType.House:
                if (nowMoney < 300)
                {
                    StartCoroutine(PlusMoney(1));
                }
                else if (nowMoney >= 300)
                {
                    StopCoroutine(PlusMoney(1));
                    isRestart = false;
                }
                break;
            case Building.buildingType.Building:
                if (nowMoney < 500)
                {
                    StartCoroutine(PlusMoney(1));
                }
                else if (nowMoney >= 500)
                {
                    StopCoroutine(PlusMoney(1));
                    isRestart = false;
                }
                break;
            case Building.buildingType.Hotel:
                if (nowMoney < 1000)
                {
                    StartCoroutine(PlusMoney(1));
                }
                else if (nowMoney >= 1000)
                {
                    StopCoroutine(PlusMoney(1));
                    isRestart = false;
                }
                break;
            default:
                break;
        }

    }
}
