using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Collections;
using UnityEngine.EventSystems;


[RequireComponent(typeof(EventTrigger))]
public class DayToggle : Toggle {

    private Nullable<DateTime> _dateTime;
    public Nullable<DateTime> dateTime { 

        get { return _dateTime;  }

        set {
             _dateTime = value;
            var todayMarker = GetTodayMarker();
            if (todayMarker != null) {

                GetTodayMarker().gameObject.SetActive(_dateTime != null && DateTime.Today.IsSameDate((DateTime)_dateTime));
            }
            
        }
    }

    public class OnDateTimeSelectedEvent : UnityEvent<Nullable<DateTime>> { }
    public OnDateTimeSelectedEvent onDateSelected = new OnDateTimeSelectedEvent();
    bool _clicked = false;

    private Image GetTodayMarker()
    {
        Component[] transforms;

        transforms = GetComponentsInChildren(typeof(Transform), true);

        foreach (Transform x in transforms)
        {
            if( x.gameObject.name == "Today Marker")
            //if (x != null && x.gameObject.name == "Today Marker")
            {
                return x.gameObject.GetComponent<Image>();
            }
        }
        return null;
    }
    public void Start()
    {
        base.Start();
        onValueChanged.AddListener(onToggleValueChanged);
        EventTrigger myEventTrigger = GetComponent<EventTrigger>();
        EventTrigger.Entry entry = new EventTrigger.Entry();
        entry.eventID = EventTriggerType.PointerUp;
        entry.callback.AddListener((data) => { OnPointerUpDelegate((PointerEventData)data); });
        myEventTrigger.triggers.Add(entry);
    }


    /*
     public class EventTriggerDelegateExample : MonoBehaviour   {
         void Start(){
         EventTrigger trigger = GetComponent<EventTrigger>();
         EventTrigger.Entry entry = new EventTrigger.Entry();
         entry.eventID = EventTriggerType.PointerDown;
         entry.callback.AddListener((data) => { OnPointerDownDelegate((PointerEventData)data); });
         trigger.triggers.Add(entry);
     }

     public void OnPointerDownDelegate(PointerEventData data)
     {
         Debug.Log("OnPointerDownDelegate called.");
     }
 }


    onValueChanged.AddListener(onToggleValueChanged);
    EventTrigger trigger = GetComponent<EventTrigger>();
    EventTrigger myEventTrigger = GetComponent<EventTrigger>();
    EventTrigger trigger = GetComponent<EventTrigger>();
    EventTrigger.Entry entry = new EventTrigger.Entry();
    entry.eventID = EventTriggerType.PointerUp;
    entry.callback.AddListener((data) => { OnPointerUpDelegate((PointerEventData)data); });
    myEventTrigger.triggers.Add(entry);




     */

    private void OnPointerUpDelegate(PointerEventData data)
    {
        if (isActiveAndEnabled && IsInteractable())
        {
            _clicked = true;
            onDateSelected.Invoke(dateTime);
        }
    }

    public void onToggleValueChanged(bool value)
    {
        AllowSwitchOff(value);
    }
   
    void AllowSwitchOff(bool value)
    {
        if (_clicked && !value)
        {
            isOn = true;
        }
        _clicked = false;
    }


    public void SetText(string text)
    {
        GetComponentInChildren<Text>().text = text;
    }

    public void ClearText()
    {
        SetText(string.Empty);
    }
}
