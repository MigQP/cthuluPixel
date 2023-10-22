using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Combinations : MonoBehaviour
{
    public TMP_Text[] combs;



    // Start is called before the first frame update
    void Start()
    {
        combs = GetComponentsInChildren<TMP_Text>();

        ResetText();


    }

    
    public void FirstNum(int numberToGive)
    {
        combs[0].text = numberToGive.ToString();
    }

    public void SecondNum(int numberToGive)
    {
        combs[1].text = numberToGive.ToString();
    }


    public void ResetText()
    {

        for (int i = 0; i < combs.Length; i++)
        {
            combs[i].text = "";
        }


    }


    public void MaloText()
    {
        combs[2].text = "malo";
    }

    public void BuenoText()
    {
        combs[2].text = "bueno";
    }


    public void SetCombo()
    {
        if (int.Parse(combs[0].text) == 1 && int.Parse(combs[1].text) == 2 || int.Parse(combs[0].text) == 2 && int.Parse(combs[1].text) == 1)
        {
            combs[2].text = "A";
        }

        if (int.Parse(combs[0].text) == 3 && int.Parse(combs[1].text) == 4 || int.Parse(combs[0].text) == 4 && int.Parse(combs[1].text) == 3)
        {
            combs[2].text = "B";
        }

        if (int.Parse(combs[0].text) == 2 && int.Parse(combs[1].text) == 4 || int.Parse(combs[0].text) == 4 && int.Parse(combs[1].text) == 2)
        {
            combs[2].text = "C";
        }

        if (int.Parse(combs[0].text) == 1 && int.Parse(combs[1].text) == 3 || int.Parse(combs[0].text) == 3 && int.Parse(combs[1].text) == 1) 
        {
            combs[2].text = "D";
        }

        if (int.Parse(combs[0].text) == 1 && int.Parse(combs[1].text) == 4 || int.Parse(combs[0].text) == 4 && int.Parse(combs[1].text) == 1)
        {
            combs[2].text = "E";
        }

        if (int.Parse(combs[0].text) == 2 && int.Parse(combs[1].text) == 3 || int.Parse(combs[0].text) == 3 && int.Parse(combs[1].text) == 2)
        {
            combs[2].text = "E";
        }
    }



}
