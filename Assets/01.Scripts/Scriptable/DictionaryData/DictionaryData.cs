using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DictionaryData", menuName = "Scriptable Object/DictionaryData", order = 1)]
public class DictionaryData : ScriptableObject
{
    [SerializeField]
    private int number;
    public int Number { get { return number; } }

    [SerializeField]
    private string myname;
    public string MyName { get { return myname; } }

    [SerializeField]
    private string explane;
    public string Explane { get { return explane; } } 


}
