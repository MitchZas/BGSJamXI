using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using static DialogueObject;
using UnityEngine.UI;

public class BooCalculator : MonoBehaviour
{
    [SerializeField] public DialogueController dControllerScript;

    public int booNumber;

    //public int goodNumber = 10;
    //public int neutralNumber = 5;
    //public int badNumber = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        booNumber = 0;
        Debug.Log(booNumber);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetLove(int pointsToAdd)
    {
        booNumber += pointsToAdd;
        Debug.Log(booNumber);
    }
}
