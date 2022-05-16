using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Building", menuName = "Scriptable Object/Building", order = 1)]
public class Building : ScriptableObject
{
    public enum buildingType
    {
        House,
        Building,
        Hotel
    }

    public buildingType BuildingType;
    [SerializeField]
    private int plusMoney;
    public int PlusMoney { get{ return plusMoney; } }

}
