using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonManager : MonoBehaviour
{
    public GameObject personPrefab;


    // Start is called before the first frame update
    void Start()
    {
        GameObject childGameObject = Instantiate(personPrefab, this.transform);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            foreach (Transform child in transform)
            {
                Destroy(child.gameObject);
            }
            GameObject childGameObject = Instantiate(personPrefab, this.transform);
        }
    }
}
