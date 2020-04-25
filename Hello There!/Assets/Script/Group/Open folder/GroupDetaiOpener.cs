using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class GroupDetaiOpener : MonoBehaviour
{
    /*Ideas
    - Contact, groupName: place for user to edit text
    - variable active -> check if panel open from add button or card
    */
    public TextMeshProUGUI contact, groupName;

    private string ID;
    
    void Start()
    { 
        Debug.Log("start");
    }

    private void OnEnable()
    {
        ID = PlayerPrefs.GetString("active");
        if(ID == "create new"){
            renderNewInformation();
            
        } else {
            renderInformation(ID);
        }
    }
    // Update is called once per frame
    
    void Update()
    {
        
    }

    public void renderInformation(string ID){// get exist information if click from previous ID
        string getInfo = PlayerPrefs.GetString(ID);
        string[] info = getInfo.Split(' ');
        Debug.Log(info.Length);
        if(contact!= null && groupName != null){
            contact.SetText(info[1]);
            groupName.SetText(info[0]);
        }
        Debug.Log(getInfo);
    }


    public void renderNewInformation(){ // create new information if click from create new 
        if(contact!= null && groupName != null){
            contact.SetText("placebo will be fill out later");
            groupName.SetText("placebo will be fill out laer");
        }
    }
}
