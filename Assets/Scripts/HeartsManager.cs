using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartsManager : MonoBehaviour
{
    public GameObject heart;

    public static HeartsManager instance;

    // Start is called before the first frame update

    void Awake()
    {
        instance = this;

    }


    void Start()
    {
        for (int i = 0; i < GameManager.instance.lives; i++)
        {
            GameObject childGameObject = Instantiate(heart, this.transform);
        }
    }


    public void DestroyHeart ()
    {
        int numChildren = this.transform.childCount;
        Destroy(this.transform.GetChild(numChildren - 1).gameObject);
    }
}
