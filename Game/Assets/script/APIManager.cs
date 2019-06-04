using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using MiniJSON;
using System;
using System.IO;
using System.Text;
using UnityEngine.Networking;

public class APIManager : MonoBehaviour
{
    public GameObject Panel;
    [SerializeField] private Transform parentTransform;
    private int i;
    public void Start()
    {
        GetJsonFromWww();
    }
    public void GetJsonFromWww()
    {

        string sTgtURL = "http://localhost/FinalRankingSystem/finalranking/GetRanking";

        StartCoroutine(GetRanking(sTgtURL, CallbackWwwSuccess, CallbackWwwFailed));
    }
    private void CallbackWwwSuccess(string response)
    {

        List<RankingData> rankingList = RankingDataModel.DesirializeFromJson(response);
		int number = 1;
        foreach (RankingData ranking in rankingList)
        {
            GameObject panel = Instantiate(Panel, Panel.transform.position, Panel.transform.rotation);
            panel.transform.SetParent(parentTransform);
			RankingPanel rankingPanel = panel.GetComponent<RankingPanel>();
			rankingPanel.SetNumberText(number.ToString());
			number++;
			rankingPanel.SetScoreText(ranking.score.ToString());
			rankingPanel.SetDateText(ranking.Date.ToString());
        }
    }

    private void CallbackWwwFailed()
    {

        Panel.GetComponent<Text>().text = "Www Failed";
    }

    private void CallbackApiSuccess(string response)
    {

        Panel.GetComponent<Text>().text = response;
    }

    private IEnumerator GetRanking(string sTgtURL, Action<string> cbkSuccess = null, Action cbkFailed = null)
    {

        WWW www = new WWW(sTgtURL);

        yield return StartCoroutine(ResponceCheckForTimeOutWWW(www, 5.0f));

        if (www.error != null)
        {
            Debug.LogError(www.error);
            if (null != cbkFailed)
            {
                cbkFailed();
            }
        }
        else
            if (www.isDone)
        {
            Debug.Log(string.Format("Success:{0}", www.text));
            if (null != cbkSuccess)
            {
                cbkSuccess(www.text);
            }
        }
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
