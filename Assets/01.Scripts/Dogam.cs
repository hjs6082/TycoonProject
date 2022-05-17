using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dogam : MonoBehaviour
{
    [SerializeField]
    private GameObject[] dogamPanels;
    public static Dogam instance;
    public Dictionary<int, bool> dogamDictionary = new Dictionary<int, bool>();
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        for (int i = 0; i < dogamPanels.Length; i++)
        {
            dogamPanels[i].transform.GetChild(0).GetComponent<Text>().text = "#" + dogamPanels[i].GetComponent<MyData>().myData.Number.ToString();
            dogamPanels[i].transform.GetChild(2).GetComponent<Text>().text = dogamPanels[i].GetComponent<MyData>().myData.MyName;
            dogamPanels[i].transform.GetChild(3).GetComponent<Text>().text = dogamPanels[i].GetComponent<MyData>().myData.Explane;
            dogamDictionary.Add(dogamPanels[i].GetComponent<MyData>().myData.Number, false);
        }
        DogamChange(1);

        DogamChange(2);

        foreach (var item in dogamDictionary)
        {
            Debug.Log(item.Value);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DogamChange(int Number)
    {
/*        foreach (var item in dogamDictionary)
        {
            if(item.Key == Number)
            {
                Debug.Log(item.Key);
                if (dogamDictionary.ContainsKey(item.Key))
                {
                    dogamDictionary.Remove(item.Key);
                    //dogamDictionary.Add(item.Key, true);
                }
            }
        }*/
/*        for (int i = 0; i < dogamDictionary.Count; i++)
        {*/
            if (dogamDictionary.ContainsKey(Number))
            {
                //Debug.Log(item.Key);
                //if (dogamDictionary.ContainsKey(item.Key))
               // {
                    dogamDictionary.Remove(Number);
                    dogamDictionary.Add(Number, true);
                    foreach (var item in dogamDictionary)
                    {
                        if(item.Value == true)
                        {
                            dogamPanels[item.Key - 1].GetComponent<Image>().color = Color.blue;
                        }
                    }
              //  }
            }

    }
}
