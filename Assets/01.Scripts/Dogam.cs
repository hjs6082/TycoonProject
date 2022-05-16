using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dogam : MonoBehaviour
{
    private Dictionary<int, bool> dogamDictionary = new Dictionary<int, bool>();
    // Start is called before the first frame update
    void Start()
    {
        dogamDictionary.Add(1, false);
        dogamDictionary.Add(2, false);
        dogamDictionary.Add(3, false);
        dogamDictionary.Add(4, false);
        dogamDictionary.Add(5, false);
        dogamDictionary.Add(6, false);
        dogamDictionary.Add(7, false);
        dogamDictionary.Add(8, false);
        dogamDictionary.Add(9, false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
