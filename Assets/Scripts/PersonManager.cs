using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonManager : MonoBehaviour
{
    public GameObject personPrefab;


    public GameObject personInScene;


    public int firstRune;
    public int secondRune;

    // Start is called before the first frame update
    void Start()
    {
        CreatePerson();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //DestroyChildrenPerson();
            //CreatePerson();
        }


    }


    public void DestroyChildrenPerson()
    {
        foreach (Transform child in transform)
        {
            Destroy(child.gameObject);
        } 

    }

    public void CreatePerson()
    {
        GameObject childGameObject = Instantiate(personPrefab, this.transform);

    }

    
}
