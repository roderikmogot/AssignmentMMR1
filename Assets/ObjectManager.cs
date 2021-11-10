using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    public GameObject[] objectNum;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeObject()
    {
        // klo nyala atau tidak
        if (objectNum[0].activeSelf)
        {
            // matiin object 0, nyalain object 1
            objectNum[0].SetActive(false);
            objectNum[1].SetActive(true);
            objectNum[2].SetActive(false);
            objectNum[3].SetActive(false);
        }
        else if (objectNum[1].activeSelf)
        {
            objectNum[0].SetActive(false);
            objectNum[1].SetActive(false);
            objectNum[2].SetActive(true);
            objectNum[3].SetActive(false);
        }
        else if (objectNum[2].activeSelf)
        {
            objectNum[0].SetActive(false);
            objectNum[1].SetActive(false);
            objectNum[2].SetActive(false);
            objectNum[3].SetActive(true);
        }
        else if (objectNum[3].activeSelf)
        {
            objectNum[0].SetActive(true);
            objectNum[1].SetActive(false);
            objectNum[2].SetActive(false);
            objectNum[3].SetActive(false);
        }
    }
}
