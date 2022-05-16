using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyData : MonoBehaviour
{
    public DictionaryData myData;
    // Start is called before the first frame update
    void Start()
    {
        Dogam.instance.dogamDictionary.Add(myData.Number, false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
