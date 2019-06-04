using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
public class result : MonoBehaviour
{
    [SerializeField] private Text currentScore;
    void Start()
    {
        currentScore.text = string.Format("score{0}", Score.score);
        SetJsonFromWww();
    }

   

    public void OnClick()
    {
        SceneManager.LoadScene("Title");
    }
     public void SetJsonFromWww()
    {
        string sTgtURL = "http://localhost/FinalRankingSystem/finalranking/SetRanking";

        StartCoroutine(Setranking(sTgtURL, Score.score, CallbackApiSuccess, CallbackWwwFailed));
    }
    private IEnumerator Setranking(string urlTarget, int score, Action<string> cbkSuccess = null, Action cbkFailed = null)
    {

        WWWForm form = new WWWForm();
        form.AddField("Score", score);

        WWW www = new WWW(urlTarget, form);

        yield return StartCoroutine(ResponceCheckForTimeOutWWW(www, 5.0f));

        if (www.error != null)
        {
            Debug.LogError(www.error);
            if (null != cbkFailed)
            {
                cbkFailed();
            }
        }
        else if (www.isDone)
        {
            Debug.Log(string.Format("Success:{0}", www.text));
            if (null != cbkSuccess)
            {
                cbkSuccess(www.text);
            }
        }
    }
    private void CallbackWwwSuccess(string response)
    {

        
    }

    private void CallbackWwwFailed()
    {

        Debug.Log("Www Failed");
    }

    private void CallbackApiSuccess(string response)
    {

        Debug.Log(response);
    }

    private IEnumerator ResponceCheckForTimeOutWWW(WWW www, float timeout)
    {
        float requestTime = Time.time;

        while (!www.isDone)
        {
            if (Time.time - requestTime < timeout)
            {
                yield return null;
            }
            else
            {
                Debug.LogWarning("TimeOut");
                break;
            }
        }
        yield return null;
    }
}
