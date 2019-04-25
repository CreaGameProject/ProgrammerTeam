using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;

public class WebAPI : MonoBehaviour
{ 
    void Start()
    {
        StartCoroutine(CoStart());
    }

    void Update()
    {
        
    }

    IEnumerator CoStart()
    {
        WWW www = new WWW("http://weather.livedoor.com/forecast/webservice/json/v1?city=300010");
        while (!www.isDone)
        {
            yield return null;
        }

        WeatherClass obj = JsonUtility.FromJson<WeatherClass>(www.text);

        string output = string.Format("{0}の天気は{1}\n", obj.location.city, obj.forecasts[0].telop);
        Debug.Log(output);
    }
}

[Serializable]
class WeatherClass
{
    public string publicTime;
    public LocationClass location;
    public ForecastsClass[] forecasts;
    public PinpointLocationsClass[] pinpointLocations;
    public DescriptionClass description;
}

[Serializable]
class PinpointLocationsClass
{
    public string link;
    public string name;
}

[Serializable]
class LocationClass
{
    public string city;
    public string area;
    public string prefecture;
}

[Serializable]
class ForecastsClass
{
    public string dateLabel;
    public string telop;
    public string date;
    public TemperatureClass temperature;
}

[Serializable]
class TemperatureClass
{
    public TemperatureNumClass min;
    public TemperatureNumClass max;
}

[Serializable]
class TemperatureNumClass
{
    public float celsius;
    public float fahrenheit;
}

[Serializable]
class DescriptionClass
{
    public string text;
    public string publicTime;
}
