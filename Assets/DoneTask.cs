using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoneTask : MonoBehaviour
{
    bool isDone;
    bool timeSet;
    string curDate;
    public void IsDone()
    {
        isDone = !isDone;

    }

    public void GetTime()
    {
        curDate = System.DateTime.Now.ToLongTimeString();
        transform.parent.GetChild(3).gameObject.GetComponent<Text>().text = curDate;
        timeSet = true;
    }

    public void Update()
    {
        if(isDone)
        {
            transform.parent.GetComponent<Text>().color = Color.grey;
            transform.parent.GetChild(0).gameObject.SetActive(false);
            transform.parent.GetChild(3).gameObject.SetActive(true);
            if(!timeSet)
            {
                GetTime();
            }

        }
        else
        {
            transform.parent.GetComponent<Text>().color = Color.black;
            transform.parent.GetChild(0).gameObject.SetActive(true);
            transform.parent.GetChild(3).gameObject.SetActive(false);
            timeSet = false;
        }

    }
}
