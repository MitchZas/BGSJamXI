using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using static DialogueObject;
using UnityEngine.UI;

public class ChangeSprite : MonoBehaviour
{
    [SerializeField] public DialogueController dControllerScript;

    [SerializeField] private Image goodImage;
    [SerializeField] private Image badImage;

    [SerializeField] private Sprite goodSprite;
    [SerializeField] private Sprite badSprite;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        goodImage = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
       if(dControllerScript.isGood)
        {
            goodImage.sprite = goodSprite;
        }

        if (dControllerScript.isBad)
        {
            badImage.sprite = badSprite;
        }
    }
}
