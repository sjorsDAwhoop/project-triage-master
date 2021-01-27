using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreSystem : MonoBehaviour
{
    [SerializeField]
    private int NumberOfBandages;
    [SerializeField]
    private int NumberOfChestseal;

    public void Addbandage(int AddingBandage)
    {
        NumberOfBandages += AddingBandage;
        Debug.Log("bandage added");
    }
    public void AddChestSeal (int AddingChestSeal)
    {
        NumberOfChestseal += AddingChestSeal;
        Debug.Log("CCeal added");
    }





}
