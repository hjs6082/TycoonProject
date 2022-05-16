using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using DG.Tweening;

public class Setting : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] AudioSource clickAudio;
    [SerializeField] private GameObject cameraIcon;
    [SerializeField] private GameObject settingIcon;
    [SerializeField] private GameObject loadIcon;
    private bool isOpen;

    public void OnPointerClick(PointerEventData eventData)
    {
        if (!isOpen)
        {
            cameraIcon.SetActive(true);
            settingIcon.SetActive(true);
            loadIcon.SetActive(true);
            cameraIcon.transform.DOLocalMoveY(0f, 0.6f);
            ClickSound();
            settingIcon.transform.DOLocalMoveY(-100f, 0.6f);
            loadIcon.transform.DOLocalMoveY(-200f, 0.6f).OnComplete(() => { isOpen = true; });
        }
        else if(isOpen)
        {
            ClickSound();
            cameraIcon.transform.DOLocalMoveY(90f, 0.6f);
            settingIcon.transform.DOLocalMoveY(90f, 0.6f);
            loadIcon.transform.DOLocalMoveY(90f, 0.6f).OnComplete(() => { EndTween(); });
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EndTween()
    {
        isOpen = false;
        cameraIcon.SetActive(false);
        settingIcon.SetActive(false);
        loadIcon.SetActive(false);
    }

    public void ClickSound()
    {
        clickAudio.Play();
    }
}
