using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;
using UnityEngine.UI;

public class ForeCast : MonoBehaviour
{
    Text text;
    public static string icon_url;

    IEnumerator Start()
    {
        text = this.GetComponent<Text>();
        WWW www = new WWW("http://weather.livedoor.com/forecast/webservice/json/v1?city=300010");
        yield return www;

        WeatherClass obj = JsonUtility.FromJson<WeatherClass>(www.text);
        text.text = string.Format("{0}の{1}の天気は{2}でしょう。最高気温は{3}℃です。また、{5}の天気は{6}でしょう。{7}", 
            obj.location.city, obj.forecasts[0].dateLabel, obj.forecasts[0].telop, obj.forecasts[0].temperature.max.celsius, obj.forecasts[0].temperature.min.celsius, obj.forecasts[1].dateLabel, obj.forecasts[1].telop, obj.description.text.Replace("\n",""));
    }

    void Update()
    {

    }
}