using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class StartManager : MonoBehaviour
{
    [SerializeField]
    private GameObject leftPanels;
    [SerializeField]
    private GameObject rightPanels;
    // Start is called before the first frame update
    void Start()
    {
        StartPanel();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartPanel()
    {
        leftPanels.transform.DOLocalMoveX(1241f, 3f).SetEase(Ease.InQuad);
        rightPanels.transform.DOLocalMoveX(885f, 3f).SetEase(Ease.InQuad);
    }
}
