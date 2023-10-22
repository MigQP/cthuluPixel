using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ComboPresser : MonoBehaviour
{

    private Button[] comboButtons;

    public TMP_Text comboText;

    private PersonManager personManager;


    private Combinations combinations;

    public AudioSource goodCombo;

    public AudioSource badCombo;


    // Start is called before the first frame update
    void Start()
    {
        comboButtons = GetComponentsInChildren<Button>();

        personManager = FindObjectOfType<PersonManager>();

        combinations = FindObjectOfType<Combinations>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void CheckCombo(TMP_Text buttonText)
    {

        if (buttonText.text == comboText.text)
        {
            Debug.Log("Correcto");

            goodCombo.Play();
        }

        else if (buttonText.text != comboText.text && comboText.text != "")
        {
            Debug.Log("Error");
            GameManager.instance.SetLives(1);

            badCombo.Play();    
        }

        else if (buttonText.text != comboText.text && comboText.text == "" && combinations.combs[0].text != "" && combinations.combs[0].text != "")
        {
            Debug.Log("Error");
            GameManager.instance.SetLives(1);

            badCombo.Play();
        }

        if (comboText.text != "")
        {
            LockButtonsAndCheck();
        }

        //LockButtonsAndCheck();
    }


    void LockButtonsAndCheck()
    {
        for (int i = 0; i < comboButtons.Length; i++)
        {
            comboButtons[i].interactable = false;
        }

        StartCoroutine(WaitToRetry());
    }


    IEnumerator WaitToRetry()
    {

        yield return new WaitForSeconds(2);

        if (!GameManager.instance.ReadIsGameOver())
        {


            for (int i = 0; i < comboButtons.Length; i++)
            {
                comboButtons[i].interactable = true;
            }


            personManager.DestroyChildrenPerson();
            personManager.CreatePerson();
            combinations.ResetText();

        }
    }

}
