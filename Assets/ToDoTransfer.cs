using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ToDoTransfer : MonoBehaviour
{
    public string toDoName;
    public GameObject inputField;
    public GameObject toDoDisplay;

    public void StoreName()
    {
        toDoName = inputField.GetComponent<Text>().text;
        toDoDisplay.GetComponent<Text>().text = toDoName;
    }

}
