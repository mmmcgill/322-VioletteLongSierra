using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Notifications.Android;

public class Notify : MonoBehaviour
{
    
   
    private AndroidNotificationChannel androidNotificationChannel;
    private const string channelId = "0";

    // Use this for initialization
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    private void CreateNotificationChannel()
    {
        androidNotificationChannel = new AndroidNotificationChannel();
        androidNotificationChannel.Id = channelId;
        androidNotificationChannel.Name = "Default Channel";
        androidNotificationChannel.Importance = Importance.High;
        androidNotificationChannel.Description = "Generic notifications";
        AndroidNotificationCenter.RegisterNotificationChannel(androidNotificationChannel);
    }

    private void OnApplicationPause(bool pause)
    {
        if (pause)
        {
            SendNotification();
        }
        else
        {
            AndroidNotificationCenter.CancelAllNotifications();
        }
    }

    private void SendNotification()
    {
        AndroidNotification notification = new AndroidNotification();
        notification.Title = "Test";
        notification.Text = "Test";
        notification.FireTime = System.DateTime.Now.AddSeconds(10);

        int id = AndroidNotificationCenter.SendNotification(notification, channelId);
        Debug.Log("Notification status = " + AndroidNotificationCenter.CheckScheduledNotificationStatus(id));
    }
}
    