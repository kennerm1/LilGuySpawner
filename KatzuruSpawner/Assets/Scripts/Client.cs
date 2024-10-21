using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Client : MonoBehaviour
{
    public TMP_Text CharName; //species name output
    public TMP_Dropdown environmentTypeOptions; //dropdown options
    public TMP_Dropdown genderOptions;
    public TMP_Dropdown seasonOptions;
    public TMP_Dropdown tempOptions;
    public Image charImage; //image output
    public Sprite[] images; //image group

    public int e;
    public int g;
    public int s;
    public int t;

    public void CharButton()
    {
        e = environmentTypeOptions.value;
        g = genderOptions.value + 1;
        s = seasonOptions.value + 1;
        t = tempOptions.value + 1;

        CharRequirements requirements = new CharRequirements
        {
            environment = e,
            gender = g,
            season = s,
            temp = t
        };

        IChar v = GetChar(requirements);
        Debug.Log(v);

        CharName.text = v.GetType().Name;

        if (v.GetType().Name == "Male Winkatzuru")
        {
            charImage.sprite = images[0];
        }
        else if (v.GetType().Name == "Female Winkatzuru")
        {
            charImage.sprite = images[1];
        }
        else if (v.GetType().Name == "Male Frühkatzuru")
        {
            charImage.sprite = images[2];
        }
        else if (v.GetType().Name == "Female Frühkatzuru")
        {
            charImage.sprite = images[3];
        }
        else if (v.GetType().Name == "Male Sommkatzuru")
        {
            charImage.sprite = images[4];
        }
        else if (v.GetType().Name == "Female Sommkatzuru")
        {
            charImage.sprite = images[5];
        }
        else if (v.GetType().Name == "Male Herbstkatzuru")
        {
            charImage.sprite = images[6];
        }
        else if (v.GetType().Name == "Female Herbstkatzuru")
        {
            charImage.sprite = images[7];
        }
    }

    private static IChar GetChar(CharRequirements requirements)
    {
        CharFactory character = new CharFactory(requirements);
        return character.Create();
    }
}