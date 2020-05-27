using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Notifications.Android;

public class NotificationManager : MonoBehaviour
{
    private void Start()
    {
        var c = new AndroidNotificationChannel()
        {
            Id = "channel_id",
            Name = "Default Channel",
            Importance = Importance.High,
            Description = "Generic notifications",
        };
        AndroidNotificationCenter.RegisterNotificationChannel(c);

        var notification = new AndroidNotification();
        notification.Title = "New Reminder";
        notification.Text = "You have a new reminder!";
        notification.FireTime = System.DateTime.Now.AddSeconds(5);
        notification.ShouldAutoCancel = true;

        AndroidNotificationCenter.SendNotification(notification, "channel_id");
    }
}

