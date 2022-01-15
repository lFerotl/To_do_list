using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EditButton : MonoBehaviour
{
    public string editString;
    public GameObject newString;
   public void TurnOnEdit()
    {
        gameObject.transform.GetChild(0).gameObject.SetActive(true);

    }

    public void TurnOffEdit()
    {
        gameObject.transform.GetChild(0).gameObject.SetActive(false);
    }

    public void StringEdit()
    {
        //editString = gameObject.transform.GetChild(0).GetComponent<InputField>().GetComponent<Text>().text;
        //Debug.Log(editString);


        //transform.parent.GetComponent<Text>().text = editString;

        editString = newString.transform.GetChild(5).GetComponent<Text>().text;
        //Debug.Log(newString.transform.GetChild(5));
        transform.parent.gameObject.GetComponent<Text>().text = editString;
        if(editString.Length>1)
        {
            TurnOffEdit();
        }
        
    }
}
