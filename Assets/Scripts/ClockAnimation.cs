using UnityEngine;
using System.Collections;
using System;

public class ClockAnimation : MonoBehaviour {

    public Transform hourTransform, minuteTransform, secondTransform;
    private float degreesInHour, degreesInMinute, degreesInSecond; // 
    public bool analog;


	// Use this for initialization
	    void Start () 
        {
            degreesInHour = 360 / 12;
            degreesInMinute = 360 / 60;
            degreesInSecond = 360 / 60;
	    }
	
	// Update is called once per frame
	void Update () {
       
        if (analog)
        {
            TimeSpan timespan = DateTime.Now.TimeOfDay;
            hourTransform.localRotation = Quaternion.Euler(0f, 0f, (float)timespan.TotalHours * -degreesInHour);
            minuteTransform.localRotation = Quaternion.Euler(0f, 0f, (float)timespan.TotalMinutes * -degreesInMinute);
            secondTransform.localRotation = Quaternion.Euler(0f, 0f, (float)timespan.TotalSeconds * -degreesInSecond);
        }
        else
        {
            DateTime time = DateTime.Now;
            hourTransform.localRotation = Quaternion.Euler(0f, 0f, time.Hour * -degreesInHour);
            minuteTransform.localRotation = Quaternion.Euler(0f, 0f, time.Minute * -degreesInMinute);
            secondTransform.localRotation = Quaternion.Euler(0f, 0f, time.Second * -degreesInSecond);
        }
            
	}
}
