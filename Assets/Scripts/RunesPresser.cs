using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RunesPresser : MonoBehaviour
{
    private Button[] buttons;

    public int count;

    public int errorCount;


    private PersonManager personManager;

    public int firstRune;

    public int secondRune;

    public GameObject errorPanel;


    private Combinations combinations;

    void Awake()
    {
        personManager = FindObjectOfType<PersonManager>();
        buttons = GetComponentsInChildren<Button>();
        combinations = FindObjectOfType<Combinations>();
    }

    // Update is called once per frame
    void Update()
    {
       ///LockButtonsAndCheck();
    }

    void LockButtonsAndCheck()
    {
        if (count >= 2)
        {
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].interactable = false;
            }

            StartCoroutine(WaitToRetry());
        }
    }

    IEnumerator WaitToRetry()
    {
        if (personManager.firstRune == firstRune && personManager.secondRune == secondRune || personManager.firstRune == secondRune && personManager.secondRune == firstRune)
        {
            //personManager.DestroyChildrenPerson();
            //personManager.CreatePerson();

            //combinations.BuenoText();
            combinations.SetCombo();
        }

        else
        {

            //Debug.Log("Te equivocaste");
            //errorPanel.SetActive(true);
            GameManager.instance.SetLives(1);
            errorCount++;
            //combinations.SetCombo();
            //combinations.MaloText();
        }


        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(2);

        if (!GameManager.instance.ReadIsGameOver())
        {

            if (personManager.firstRune == firstRune && personManager.secondRune == secondRune || personManager.firstRune == secondRune && personManager.secondRune == firstRune)
            {
                /*
                personManager.DestroyChildrenPerson();
                personManager.CreatePerson();
                */
            }

            else
            {
                Debug.Log("Te equivocaste");


                personManager.DestroyChildrenPerson();
                personManager.CreatePerson();
                combinations.ResetText();

            }


            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].interactable = true;
                count = 0;
                firstRune = 0;
                secondRune = 0;
                errorPanel.SetActive(false);
                //combinations.ResetText();
            }

        }

    }


    public void CounterClick(Button runeButton)
    {

        count++;


        for (int i = 0; i < buttons.Length; i++)
        {
            if (runeButton == buttons[i] && count == 1)
            {
                firstRune = i + 1;
                combinations.FirstNum(firstRune);
            }

            if (runeButton == buttons[i] && count == 2)
            {
                secondRune = i + 1;
                combinations.SecondNum(secondRune);
            }
        }

        runeButton.interactable = false;

        LockButtonsAndCheck();
    }
}
