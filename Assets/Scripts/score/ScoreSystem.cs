using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreSystem : MonoBehaviour
{
    [SerializeField]
    private int Score;

    public void AddScore(int AddingScore)
    {
        Score += AddingScore;
        Debug.Log("called");
    }





}
