using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class BuildingScript : MonoBehaviour, IPointerClickHandler
{
    [SerializeField]
    private Building building;

    //public int myMoney;

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
        myMoneyText.text = UIManager.instance.myMoney.ToString();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (nowMoney != 0)
        {
            AudioManager.instnace.PlusMoneySound();
            nowMoneyText.text = "+" + nowMoney.ToString();
            UIManager.instance.PlusMoney();
            UIManager.instance.myMoney += nowMoney;   
            switch (building.BuildingType)
            {
                case Building.buildingType.House:
                    if (nowMoney == 300)
                    {
                        StartCoroutine(PlusMoney(1));
                    }
                    break;
                case Building.buildingType.Building:
                    if (nowMoney == 500)
                    {
                        StartCoroutine(PlusMoney(1));
                    }
                    break;
                case Building.buildingType.Hotel:
                    if (nowMoney == 1050)
                    {
                        StartCoroutine(PlusMoney(1));
                    }
                    break;
                default:
                    break;
            }

            nowMoney = 0;
        }
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
                }
                break;
            case Building.buildingType.Hotel:
                if (nowMoney < 1050)
                {
                    StartCoroutine(PlusMoney(1));
                }
                else if (nowMoney >= 1050)
                {
                    StopCoroutine(PlusMoney(1));
                }
                break;
            default:
                break;
        }

    }


}
