using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DateTimeController : MonoBehaviour
{
    public Dates _date;
    public Timecontroller _time;


    public DateTime? SelectedDateTime()
    {
        var _Date = _date.SelectedDate;
        var _Time = _time.SelectedTime();
        if (_Date != null)
        {
            return new DateTime(_Date.Value.Year, _Date.Value.Month, _Date.Value.Day,
                            _Time.Hour, _Time.Minute, _Time.Second);
        }
        return null;
    }

    public void SetSelectedDateTime(DateTime value)
    {
        _date.SetSelectedDate(value);
        _time.SetSelectedTime(value);
    }
}

