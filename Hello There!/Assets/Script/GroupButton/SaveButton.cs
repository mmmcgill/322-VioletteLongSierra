using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SaveButton : MonoBehaviour
{
    /*Ideas:
    generate new random ID and put stuff inside
    */
    // Start is called before the first frame update

    public TextMeshProUGUI  newContact, newGroupName;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnEnable() {

    }

    public void submit(){//add to Group controller Dictionaries
        if(newContact != null && newGroupName != null){
            string information = newContact.text + " " + newGroupName.text;
            string ID = PlayerPrefs.GetString("active");
            if(ID == "create new"){
                string randomID = System.Guid.NewGuid().ToString();
                string newID = PlayerPrefs.GetString("ID_List") + " " + randomID;
                PlayerPrefs.SetString("ID_List", newID); // first time open app
                PlayerPrefs.SetString(randomID, information); // new information
                PlayerPrefs.SetString("active", randomID);
            } else {
                PlayerPrefs.SetString(ID, information); // replace old information
            }
            Debug.Log(information);
        }
    }
}
