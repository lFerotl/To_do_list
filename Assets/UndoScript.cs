using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UndoScript : MonoBehaviour
{
    bool isDeleting = true;

    public GameObject whichDelete;

    [SerializeField] private float time;
    [SerializeField] private Text timerText;

    private float _timeLeft = 0f;

    private IEnumerator StartTimer()
    {
        while (_timeLeft > 0)
        {
            _timeLeft -= Time.deltaTime;
            UpdateTimeText();
            yield return null;
        }
    }

    private void UpdateTimeText()
    {
        if (_timeLeft < 0)
            _timeLeft = 0;

        float minutes = Mathf.FloorToInt(_timeLeft / 60);
        float seconds = Mathf.FloorToInt(_timeLeft % 60);
        timerText.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }
    public void UndoBegin()
    {
        whichDelete.SetActive(false);
        StartCoroutine(Begin());
    }
    public void Undo()
    {
        whichDelete.SetActive(true);
        Debug.Log("stop destroy");
        gameObject.SetActive(false);
    }
    IEnumerator Begin()
    {
        _timeLeft = time;
        StartCoroutine(StartTimer());
        yield return new WaitForSeconds(time);
        if (isDeleting)
        {
            
            gameObject.SetActive(false);
            //Destroy(transform.GetChild(1).gameObject.SetActive(false))
        }

    }

}
