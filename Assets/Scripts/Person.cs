using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Person : MonoBehaviour
{
    public TMP_Text firstNumber;

    public TMP_Text secondNumber;

    public int minRange = 1;
    public int maxRange = 5;

    public int firstRandomNumber;
    public int secondRandomNumber;

    private PersonManager personManager;

    public Sprite[] personsSprites;

    public GameObject[] characters;


    public GameObject[] runesAnims;

    public Transform textbox;

    private void Awake()
    {
        personManager = FindObjectOfType<PersonManager>();
    }

    // Start is called before the first frame update
    void Start()
    {
        // Generate the first random number
        firstRandomNumber = Random.Range(minRange, maxRange);


        GameObject childGameObject = Instantiate(characters[firstRandomNumber - 1], this.transform);


        // Generate the second random number while it is the same as the first
        do
        {
            secondRandomNumber = Random.Range(minRange, maxRange);
        } while (secondRandomNumber == firstRandomNumber);

        Debug.Log("First Random Number: " + firstRandomNumber);
        Debug.Log("Second Random Number: " + secondRandomNumber);


        firstNumber.text = firstRandomNumber.ToString();
        secondNumber.text = secondRandomNumber.ToString();
        personManager.firstRune = firstRandomNumber;
        personManager.secondRune = secondRandomNumber;

        GameObject childGameObject1 = Instantiate(runesAnims[secondRandomNumber - 1], textbox);
    }


}
