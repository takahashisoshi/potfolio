using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MiniJSON;

public class RankingDataModel : MonoBehaviour {

	// Use this for initialization
	static public List<RankingData> DesirializeFromJson(string sStrJson){
		List<RankingData>	ret	= new List<RankingData> ();
		RankingData	tmp = null;
		      
		IList jsonList = (IList)Json.Deserialize(sStrJson);

		foreach (IDictionary jsonOne in jsonList) {

			tmp = new RankingData ();

			if (jsonOne.Contains ("Score")) {
				tmp.score	= (int)(long)jsonOne ["Score"];
			}
			if (jsonOne.Contains ("Date")) {
				tmp.Date	= (string)jsonOne ["Date"];
			}

			ret.Add (tmp);
			tmp	= null;
		}
		return ret;
	}
}


