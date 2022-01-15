using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToDoListMain : MonoBehaviour
{
    public string toDoString;
    public GameObject inputField;

    public GameObject newToDo;
    public GameObject canvas;

    public int i;

    //Destroy(objectName.gameObject, 4f);


    //public void StoreName()
    //{
    //    toDoString = inputField.GetComponent<Text>().text;
    //    newToDo.GetComponent<Text>().text = toDoString;
    //    Debug.Log(toDoString.Length>1);
    //}

    public void CreateNewString()
    {
        //StoreName();

        toDoString = inputField.GetComponent<Text>().text;
        newToDo.GetComponent<Text>().text = toDoString;
        Debug.Log(toDoString.Length);

        if(toDoString.Length>1)
        {
            i++;

            GameObject toDoStingClone = Instantiate(newToDo);
            toDoStingClone.transform.parent = canvas.transform;

            toDoStingClone.GetComponent<RectTransform>().sizeDelta = newToDo.GetComponent<RectTransform>().sizeDelta;
            toDoStingClone.GetComponent<RectTransform>().localScale = newToDo.GetComponent<RectTransform>().localScale;

            toDoStingClone.GetComponent<RectTransform>().anchoredPosition = newToDo.GetComponent<RectTransform>().anchoredPosition + (new Vector2(0, -180) * i);

            toDoStingClone.gameObject.SetActive(true);
        }
    }
    //public void DeleteButton()
    //{
    //    Debug.Log("Destroyed?");
    //    Destroy(transform.parent.gameObject);

    public void EditString()
    {
        
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.KeypadEnter))

        {
            Debug.Log("Enter Pressed");

            CreateNewString();

        }

    }

}
