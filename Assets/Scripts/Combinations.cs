using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Combinations : MonoBehaviour
{
    public TMP_Text[] combs;


    public GameObject[] runeSpawnPoints;

    public GameObject runeToSpawn;

    public Sprite[] runes;


    // Start is called before the first frame update
    void Start()
    {
        combs = GetComponentsInChildren<TMP_Text>();

        ResetText();


    }

    
    public void FirstNum(int numberToGive)
    {
        combs[0].text = numberToGive.ToString();

       if (numberToGive == 1)
       {
            GameObject childGameObject = Instantiate(runeToSpawn, runeSpawnPoints[0].transform);
            childGameObject.GetComponent<Image>().sprite = runes[0];
       }

       
       if (numberToGive == 2)
       {
            GameObject childGameObject = Instantiate(runeToSpawn, runeSpawnPoints[0].transform);
            childGameObject.GetComponent<Image>().sprite = runes[1];
       }

       
       if (numberToGive == 3)
       {
            GameObject childGameObject = Instantiate(runeToSpawn, runeSpawnPoints[0].transform);
            childGameObject.GetComponent<Image>().sprite = runes[2];
       }

       
       if (numberToGive == 4)
       {
           GameObject childGameObject = Instantiate(runeToSpawn, runeSpawnPoints[0].transform);
           childGameObject.GetComponent<Image>().sprite = runes[3];
       }
    }

    public void SecondNum(int numberToGive)
    {
        combs[1].text = numberToGive.ToString();

        if (numberToGive == 1)
        {
            GameObject childGameObject = Instantiate(runeToSpawn, runeSpawnPoints[1].transform);
            childGameObject.GetComponent<Image>().sprite = runes[0];
        }


        if (numberToGive == 2)
        {
            GameObject childGameObject = Instantiate(runeToSpawn, runeSpawnPoints[1].transform);
            childGameObject.GetComponent<Image>().sprite = runes[1];
        }


        if (numberToGive == 3)
        {
            GameObject childGameObject = Instantiate(runeToSpawn, runeSpawnPoints[1].transform);
            childGameObject.GetComponent<Image>().sprite = runes[2];
        }


        if (numberToGive == 4)
        {
            GameObject childGameObject = Instantiate(runeToSpawn, runeSpawnPoints[1].transform);
            childGameObject.GetComponent<Image>().sprite = runes[3];
        }
    }

    public void ThirdNum(int numberToGive)
    {
        if (combs[0].text != "" && combs[1].text != "")
        {
            if (numberToGive == 1)
            {
                GameObject childGameObject = Instantiate(runeToSpawn, runeSpawnPoints[2].transform);
                childGameObject.GetComponent<Image>().sprite = runes[4];
            }


            if (numberToGive == 2)
            {
                GameObject childGameObject = Instantiate(runeToSpawn, runeSpawnPoints[2].transform);
                childGameObject.GetComponent<Image>().sprite = runes[5];
            }


            if (numberToGive == 3)
            {
                GameObject childGameObject = Instantiate(runeToSpawn, runeSpawnPoints[2].transform);
                childGameObject.GetComponent<Image>().sprite = runes[6];
            }


            if (numberToGive == 4)
            {
                GameObject childGameObject = Instantiate(runeToSpawn, runeSpawnPoints[2].transform);
                childGameObject.GetComponent<Image>().sprite = runes[7];
            }

            if (numberToGive == 5)
            {
                GameObject childGameObject = Instantiate(runeToSpawn, runeSpawnPoints[2].transform);
                childGameObject.GetComponent<Image>().sprite = runes[8];
            }


            if (numberToGive == 6)
            {
                GameObject childGameObject = Instantiate(runeToSpawn, runeSpawnPoints[2].transform);
                childGameObject.GetComponent<Image>().sprite = runes[9];
            }
        }
    }


    public void ResetText()
    {

        for (int i = 0; i < combs.Length; i++)
        {
            combs[i].text = "";
        }

        for (int i = 0; i < runeSpawnPoints.Length; i++)
        {
            Destroy(runeSpawnPoints[i].transform.GetChild(0).gameObject);
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

            //GameObject childGameObject = Instantiate(runeToSpawn, runeSpawnPoints[2].transform);
            //childGameObject.GetComponent<Image>().sprite = runes[4];
        }

        if (int.Parse(combs[0].text) == 3 && int.Parse(combs[1].text) == 4 || int.Parse(combs[0].text) == 4 && int.Parse(combs[1].text) == 3)
        {
            combs[2].text = "B";

            //GameObject childGameObject = Instantiate(runeToSpawn, runeSpawnPoints[2].transform);
            //childGameObject.GetComponent<Image>().sprite = runes[5];
        }

        if (int.Parse(combs[0].text) == 2 && int.Parse(combs[1].text) == 4 || int.Parse(combs[0].text) == 4 && int.Parse(combs[1].text) == 2)
        {
            combs[2].text = "C";

            //GameObject childGameObject = Instantiate(runeToSpawn, runeSpawnPoints[2].transform);
            //childGameObject.GetComponent<Image>().sprite = runes[6];
        }

        if (int.Parse(combs[0].text) == 1 && int.Parse(combs[1].text) == 3 || int.Parse(combs[0].text) == 3 && int.Parse(combs[1].text) == 1) 
        {
            combs[2].text = "D";

            //GameObject childGameObject = Instantiate(runeToSpawn, runeSpawnPoints[2].transform);
            //childGameObject.GetComponent<Image>().sprite = runes[7];
        }

        if (int.Parse(combs[0].text) == 1 && int.Parse(combs[1].text) == 4 || int.Parse(combs[0].text) == 4 && int.Parse(combs[1].text) == 1)
        {
            combs[2].text = "E";

            //GameObject childGameObject = Instantiate(runeToSpawn, runeSpawnPoints[2].transform);
            //childGameObject.GetComponent<Image>().sprite = runes[8];
        }

        if (int.Parse(combs[0].text) == 2 && int.Parse(combs[1].text) == 3 || int.Parse(combs[0].text) == 3 && int.Parse(combs[1].text) == 2)
        {
            combs[2].text = "E";

            //GameObject childGameObject = Instantiate(runeToSpawn, runeSpawnPoints[2].transform);
            //childGameObject.GetComponent<Image>().sprite = runes[9];
        }

    }



}
