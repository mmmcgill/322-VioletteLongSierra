using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.UI.Dropdown;

[RequireComponent(typeof(Dropdown))]
public class Times : MonoBehaviour
{
    void Start()
    {
        _TickerControl();
    }

    private Dropdown _ticker = null;
    private Dropdown ticker
    {
        get
        {
            if (_ticker != null)
            {
                return _ticker;

            }
            else if (_ticker == null)
            {
                _ticker = this.GetComponent<Dropdown>();
            }
            return _ticker;
        }
    }

    public void _TickerControl()
    {
        _ticker.ClearOptions();
        List<string> timeTicker = new List<string>();
        for (int i = 0; i < 60; i++)
        {
            timeTicker.Add(i.ToString(""));
        }
        _ticker.AddOptions(timeTicker);
    }

}
