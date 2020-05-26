using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.UI.Dropdown;

[RequireComponent(typeof(Dropdown))]
public class MinSeconds : MonoBehaviour
{
    void Start()
    {
        _minController();
    }
    private Dropdown _min;
    private Dropdown _Min
    {
        get
        {
            if (_min != null)
            {
                return _min;

            }
            else if (_min == null)
            {
                _min = this.GetComponent<Dropdown>();
            }
            return _min;
        }
    }

    public int SelectedValue
    {
        get { return _min.value; }
        set { _min.value = value; }
    }

    public void _minController()
    {
        _min.ClearOptions();
        List<string> storedMin = new List<string>();
        for (int i = 0; i < 60; i++)
        {
            storedMin.Add(i.ToString(""));
        }
        _min.AddOptions(storedMin);
    }


}
