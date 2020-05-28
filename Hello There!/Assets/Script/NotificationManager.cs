using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Notifications.Android;
using System;
using UnityEngine.UI;

public class NotificationManager : MonoBehaviour
{
    public Toggle Monday;
    public Toggle Tuesday;
    public Toggle Wednesday;
    public Toggle Thursday;
    public Toggle Friday;
    public Toggle Saturday;
    public Toggle Sunday;


    public void Notify()
    {
        if (Monday.isOn)
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

            DateTime dateToNotify = System.DateTime.Now.AddDays(7);
            //DateTime repeat = dateToNotify.AddDays(7);
            notification.FireTime = dateToNotify.AddSeconds(5);
            notification.RepeatInterval = notification.RepeatInterval;
            notification.ShouldAutoCancel = true;


            AndroidNotificationCenter.SendNotification(notification, "channel_id");

            Debug.Log("Notification Monday");
        }

        if (Tuesday.isOn)
        {
            var addNotification2 = new AndroidNotificationChannel()
            {
                Id = "channel_id",
                Name = "Default Channel",
                Importance = Importance.High,
                Description = "Generic notifications",

            };
            AndroidNotificationCenter.RegisterNotificationChannel(addNotification2);

            var notification = new AndroidNotification();
            notification.Title = "New Reminder";
            notification.Text = "You have a new reminder scheduled!";
            notification.SmallIcon = "icon_0";

            DateTime dateToNotify = System.DateTime.Now.AddDays(7);
            //DateTime repeat = dateToNotify.AddDays(7);
            notification.FireTime = dateToNotify.AddSeconds(5);
            notification.RepeatInterval = notification.RepeatInterval;
            notification.ShouldAutoCancel = true;


            AndroidNotificationCenter.SendNotification(notification, "channel_id");

            Debug.Log("Notification Tuesday");
        }

        if (Wednesday.isOn)
        {
            var addNotification3 = new AndroidNotificationChannel()
            {
                Id = "channel_id",
                Name = "Default Channel",
                Importance = Importance.High,
                Description = "Generic notifications",

            };
            AndroidNotificationCenter.RegisterNotificationChannel(addNotification3);

            var notification = new AndroidNotification();
            notification.Title = "New Reminder";
            notification.Text = "You have a new reminder scheduled!";
            notification.SmallIcon = "icon_0";

            DateTime dateToNotify = System.DateTime.Now.AddDays(7);
            //DateTime repeat = dateToNotify.AddDays(7);
            notification.FireTime = dateToNotify.AddSeconds(5);
            notification.RepeatInterval = notification.RepeatInterval;
            notification.ShouldAutoCancel = true;


            AndroidNotificationCenter.SendNotification(notification, "channel_id");

            Debug.Log("Notification Wednesday");
        }

        if (Thursday.isOn)
        {
            var addNotification3 = new AndroidNotificationChannel()
            {
                Id = "channel_id",
                Name = "Default Channel",
                Importance = Importance.High,
                Description = "Generic notifications",

            };
            AndroidNotificationCenter.RegisterNotificationChannel(addNotification3);

            var notification = new AndroidNotification();
            notification.Title = "New Reminder";
            notification.Text = "You have a new reminder scheduled!";
            notification.SmallIcon = "icon_0";

            DateTime dateToNotify = System.DateTime.Now.AddDays(7);
            //DateTime repeat = dateToNotify.AddDays(7);
            notification.FireTime = dateToNotify.AddSeconds(5);
            notification.RepeatInterval = notification.RepeatInterval;
            notification.ShouldAutoCancel = true;


            AndroidNotificationCenter.SendNotification(notification, "channel_id");

            Debug.Log("Notification Thursday");
        }

        if (Friday.isOn)
        {
            var addNotification4 = new AndroidNotificationChannel()
            {
                Id = "channel_id",
                Name = "Default Channel",
                Importance = Importance.High,
                Description = "Generic notifications",

            };
            AndroidNotificationCenter.RegisterNotificationChannel(addNotification4);

            var notification = new AndroidNotification();
            notification.Title = "New Reminder";
            notification.Text = "You have a new reminder scheduled!";
            notification.SmallIcon = "icon_0";

            DateTime dateToNotify = System.DateTime.Now.AddDays(7);
            //DateTime repeat = dateToNotify.AddDays(7);
            notification.FireTime = dateToNotify.AddSeconds(5);
            notification.RepeatInterval = notification.RepeatInterval;
            notification.ShouldAutoCancel = true;


            AndroidNotificationCenter.SendNotification(notification, "channel_id");

            Debug.Log("Notification Friday");
        }

        if (Saturday.isOn)
        {
            var addNotification5 = new AndroidNotificationChannel()
            {
                Id = "channel_id",
                Name = "Default Channel",
                Importance = Importance.High,
                Description = "Generic notifications",

            };
            AndroidNotificationCenter.RegisterNotificationChannel(addNotification5);

            var notification = new AndroidNotification();
            notification.Title = "New Reminder";
            notification.Text = "You have a new reminder scheduled!";
            notification.SmallIcon = "icon_0";

            DateTime dateToNotify = System.DateTime.Now.AddDays(7);
            //DateTime repeat = dateToNotify.AddDays(7);
            notification.FireTime = dateToNotify.AddSeconds(5);
            notification.RepeatInterval = notification.RepeatInterval;
            notification.ShouldAutoCancel = true;


            AndroidNotificationCenter.SendNotification(notification, "channel_id");

            Debug.Log("Notification Saturday");
        }

        if (Sunday.isOn)
        {
            var addNotification6 = new AndroidNotificationChannel()
            {
                Id = "channel_id",
                Name = "Default Channel",
                Importance = Importance.High,
                Description = "Generic notifications",

            };
            AndroidNotificationCenter.RegisterNotificationChannel(addNotification6);

            var notification = new AndroidNotification();
            notification.Title = "New Reminder";
            notification.Text = "You have a new reminder scheduled!";
            notification.SmallIcon = "icon_0";

            DateTime dateToNotify = System.DateTime.Now.AddDays(7);
            //DateTime repeat = dateToNotify.AddDays(7);
            notification.FireTime = dateToNotify.AddSeconds(5);
            notification.RepeatInterval = notification.RepeatInterval;
            notification.ShouldAutoCancel = true;


            AndroidNotificationCenter.SendNotification(notification, "channel_id");

            Debug.Log("Notification Sunday");
        }

    }
}
    /*
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

        DateTime dateToNotify = System.DateTime.Now.AddDays(7);
        //DateTime repeat = dateToNotify.AddDays(7);
        notification.FireTime = dateToNotify.AddSeconds(5);
        notification.RepeatInterval = notification.RepeatInterval;
        notification.ShouldAutoCancel = true;
        

        AndroidNotificationCenter.SendNotification(notification, "channel_id");

        Debug.Log("Notification Monday");
        // var currentDate = System.DateTime.Now;
        // var targetDate = new DateTime(dateToNotify.Year, dateToNotify.Month, dateToNotify.Day);
        //  targetDate = ();

        //notification.FireTime = targetDate;
       // notification.FireTime = repeat.AddSeconds(5);
       // notification.ShouldAutoCancel = true;

        
    }
}
  */


