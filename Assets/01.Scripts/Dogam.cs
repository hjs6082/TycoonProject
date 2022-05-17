using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dogam : MonoBehaviour
{
    [SerializeField]
    private Text dogamCountText;
    [SerializeField]
    private GameObject[] dogamPanels;
    public static Dogam instance;
    public Dictionary<int, bool> dogamDictionary = new Dictionary<int, bool>();

    private int dogamCount = 0;
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
        if (dogamDictionary.ContainsKey(Number))
        {
            dogamDictionary.Remove(Number);
            dogamDictionary.Add(Number, true);
            foreach (var item in dogamDictionary)
            {
                if(item.Value == true)
                {
                    dogamPanels[item.Key - 1].GetComponent<Image>().color = Color.blue;
                }
            }
        }
        dogamCount = 0;
        foreach (var item in dogamDictionary)
        {
            if (item.Value == true)
            {
                dogamCount++;
            }
        }
        dogamCountText.text = "8개 중 " + dogamCount + " 개의 캐릭터 발견";
    }

}
