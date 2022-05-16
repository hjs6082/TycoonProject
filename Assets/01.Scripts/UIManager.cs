using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    public GameObject plusMoneyPanel;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlusMoney()
    {
        plusMoneyPanel.SetActive(true);
        plusMoneyPanel.transform.DOLocalMoveY(334f, 0.5f).
            OnComplete(() => { plusMoneyPanel.SetActive(false); });
        plusMoneyPanel.transform.localPosition = new Vector2(0, 188f);
    }
}
