using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class GroupDetaiOpener : MonoBehaviour
{
    /*Ideas
    - Contact, groupName: place for user to edit text
    - variable active -> check if panel open from add button or card
    */
    public GameObject Canvas, contact, groupName;
    private TMP_InputField Contact, GroupName;
    private GroupInformationcontrol controller;

    private string ID;
    
    void Start()
    { 
        controller = Canvas.GetComponent<GroupInformationcontrol>();
        //Debug.Log("start");
    }

    /*private void OnEnable()
    {
        Contact = contact.GetComponent<TMP_InputField>();
        GroupName = groupName.GetComponent<TMP_InputField>();
        controller = Canvas.GetComponent<GroupInformationcontrol>();
        ID = controller.getActive();
        Debug.Log(ID);
        if(ID == "create new"){
            Debug.Log("yes");
            renderNewInformation();
        } else {
            renderInformation(ID);
        }
    }*/
    // Update is called once per frame
    
    void Update()
    {
        
    }

    public void renderInformation(string group){// get exist information if click from previous ID
        GroupName.text = group;
    }


    public void renderNewInformation(){ // create new information if click from create new 
    }
}
