using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Notifications.Android;
using System;

public class NotificationManager : MonoBehaviour
{

    public void AddNotify()
    {
        var addNotification = new AndroidNotificationChannel()
        {
            Id = "channel_id",
            Name = "Default Channel",
            Importance = Importance.High,
            Description = "Generic notifications",

        };
        AndroidNotificationCenter.RegisterNotificationChannel(addNotification);
  
        var notification = new AndroidNotification();
        notification.Title = "New Reminder";
        notification.Text = "You have a new reminder scheduled!";
        notification.SmallIcon = "icon_0";

        DateTime dateToNotify = System.DateTime.Now;
        DateTime repeat = dateToNotify.AddDays(7);
        notification.FireTime = repeat.AddSeconds(5);
        notification.RepeatInterval = notification.RepeatInterval;
        notification.ShouldAutoCancel = true;

        AndroidNotificationCenter.SendNotification(notification, "channel_id");

        Debug.Log("Notification sent");
        // var currentDate = System.DateTime.Now;
        // var targetDate = new DateTime(dateToNotify.Year, dateToNotify.Month, dateToNotify.Day);
        //  targetDate = ();

        //notification.FireTime = targetDate;
       // notification.FireTime = repeat.AddSeconds(5);
       // notification.ShouldAutoCancel = true;

        
    }
}
  


