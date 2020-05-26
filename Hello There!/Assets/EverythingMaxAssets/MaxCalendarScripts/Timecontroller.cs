using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timecontroller : MonoBehaviour
{
    public Hours hours;
    public MinSeconds _min;
    public MinSeconds _sec;

    public DateTime SelectedTime()
    {
        return new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day,
                            hours.SelectedValue, _min.SelectedValue, _sec.SelectedValue);
    }

    public void SetSelectedTime(int hour, int minute, int second)
    {
        hours.SelectedValue = hour;
        _min.SelectedValue = minute;
        _sec.SelectedValue = second;
    }
    public void SetSelectedTime(DateTime value)
    {
        SetSelectedTime(value.Hour, value.Minute, value.Second);
    }


    public void Now_onClick()
    {
        SetSelectedTime(DateTime.Now);
    }

    public void ReminderTime_onClick()
    {
        SetSelectedTime(hours.SelectedValue, _min.SelectedValue, _sec.SelectedValue);
    }
}


