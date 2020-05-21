using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteButton : MonoBehaviour
{
    public GameObject ContactListPage;
    private contactlist contact;
    // Start is called before the first frame update
    void OnEnable()
    {
        contact = ContactListPage.GetComponent<contactlist>();
    }

    // Update is called once per frame
    public void onClick(){
        string command = PlayerPrefs.GetString("id");
        if(command == "create new") return;
        contact.RemoveCard(PlayerPrefs.GetString("id"));
    }
}
