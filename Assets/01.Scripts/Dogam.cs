using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dogam : MonoBehaviour
{
    public static Dogam instance;
    public Dictionary<int, bool> dogamDictionary = new Dictionary<int, bool>();
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
