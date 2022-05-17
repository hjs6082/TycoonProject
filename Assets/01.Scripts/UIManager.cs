using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    public int myMoney;
    public GameObject plusMoneyPanel;
    private bool isClick = false;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 point = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,
                Input.mousePosition.y, -Camera.main.transform.position.z));
        if (!isClick)
        {
            plusMoneyPanel.transform.position = point;
        }
    }

    public void PlusMoney()
    {
        isClick = true;
        plusMoneyPanel.SetActive(true);
        if (plusMoneyPanel.transform.localPosition.y <= 0)
        {
            plusMoneyPanel.transform.DOLocalMoveY(320f, 0.5f).
                OnComplete(() => { PanelSetting(); });
        }
        else if(plusMoneyPanel.transform.localPosition.y > 0)
        {
            plusMoneyPanel.transform.DOLocalMoveY(320f, 0.5f). 
               OnComplete(() => { PanelSetting(); });
        }
    }

    public void PanelSetting()
    {
        isClick = false;
        plusMoneyPanel.SetActive(false);
    }
}
