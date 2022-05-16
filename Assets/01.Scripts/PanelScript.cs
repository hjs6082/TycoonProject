using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class PanelScript : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject loadPanel;
    public enum panelType
    {
        start,
        Load,
        Setting,
        End
    }
    public panelType PanelType;
    private bool isPanel = false;
    private bool isLoad = false;
    private bool isSetting = false;


    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("4");
        if (isPanel == false)
        {
            switch (PanelType)
            {
                case panelType.start:
                    SceneManager.LoadScene("MainScene");
                    break;
                case panelType.Load:
                    Debug.Log(2);
                    LoadPanelMove();
                    break;
                case panelType.Setting:
                    break;
                case panelType.End:
                    Application.Quit();
                    break;
                default:
                    break;
            }
        }
    }
    
    public void LoadPanelMove()
    { 
        loadPanel.transform.DOLocalMoveX(-1f, 1f).OnComplete(() => { isPanel = true; });

        isLoad = true;
    }

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(isPanel == true)
            {
                if(isLoad)
                {
                    loadPanel.transform.DOLocalMoveX(2787f, 1f).OnComplete(() => { isPanel = false; });      
                }
            }
        }
    }

}
