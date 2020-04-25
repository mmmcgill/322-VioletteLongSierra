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
    public TextMeshProUGUI  Contact, GroupName;
    void Start()
    {
        Contact = GetComponent<TextMeshProUGUI>();
        GroupName = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnEnable() {
        Contact = GetComponent<TextMeshProUGUI>();
        GroupName = GetComponent<TextMeshProUGUI>();
    }

    public void submit(){
        if(Contact != null && GroupName != null){
            string information = Contact.text + " " + GroupName.text;
            string ID = PlayerPrefs.GetString("active");
            if(ID == "create new"){
                string randomID = "generate random ID here";
                PlayerPrefs.SetString(randomID, information);
            } else {
                PlayerPrefs.SetString(ID, information);
            }
            Debug.Log(information);
        }
    }
}
