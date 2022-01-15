using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyButton : MonoBehaviour
{
    [SerializeField] private GameObject undoBut;

    public void ConfirmlMenu()
    {
        transform.GetChild(0).gameObject.SetActive(true);

    }

    public void ConfirmMenuOff()
    {
        transform.GetChild(0).gameObject.SetActive(false);
    }

    
    public void DeleteButton()
    {
        undoBut.SetActive(true);
        ConfirmMenuOff();
        undoBut.GetComponent<UndoScript>().whichDelete = transform.parent.gameObject;
        undoBut.GetComponent<UndoScript>().UndoBegin();
        //gameObject.SetActive(false);

        

        //Destroy(transform.parent.gameObject, timeToDestroy);
    }

   

}
