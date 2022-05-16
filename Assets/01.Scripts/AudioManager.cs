using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instnace;
    [SerializeField]
    private AudioSource clickSound;
    // Start is called before the first frame update
    void Start()
    {
        instnace = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlusMoneySound()
    {
        clickSound.Play();
    }
}
