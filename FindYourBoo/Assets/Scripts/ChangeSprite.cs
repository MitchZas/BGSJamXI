using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using static DialogueObject;
using UnityEngine.UI;

public class ChangeSprite : MonoBehaviour
{
    [SerializeField] public DialogueController dControllerScript;

    [SerializeField] BooCalculator booCalcnumber;

    [SerializeField] private Image goodImage;
    [SerializeField] private Image badImage;
    [SerializeField] private Image neutralImage;

    [SerializeField] public Sprite goodSprite;
    [SerializeField] public Sprite badSprite;
    [SerializeField] public Sprite neutralSprite;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        goodImage = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
       if(booCalcnumber.booNumber >=5)
        {
            goodImage.sprite = goodSprite;
        }

        else if (booCalcnumber.booNumber < 0)
        {
            badImage.sprite = badSprite;
        }

        else
        {
            neutralImage.sprite = neutralSprite;
        }
    }
}
