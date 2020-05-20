using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SaveButton : MonoBehaviour
{
    /*Ideas:
    generate new random ID and put stuff inside
    */
    // Start is called before the first frame update
    public GameObject Canvas;
    private GroupInformationcontrol controller;
    public TextMeshProUGUI  newContact, newGroupName;
    public GameObject ContactListPage;
    private contactlist contact;
    public TMP_InputField discord, interest, mobile, bday ,name, notes;
    string command;

    void Start()
    {
        contact = ContactListPage.GetComponent<contactlist>();
        controller = Canvas.GetComponent<GroupInformationcontrol>();
        individual = controller.GetIndividualMap();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnEnable() {
        contact = ContactListPage.GetComponent<contactlist>();
        controller = Canvas.GetComponent<GroupInformationcontrol>();
        command = PlayerPrefs.GetString("id");
        Debug.Log(command);
        if(command == "create new"){
            discord.text = "";
            interest.text = "";
            mobile.text = "";
            bday.text = "";
            name.text = "";
            notes.text = "";
            //Debug.Log(notes.text);
        } else {
            string information = controller.GetIndividual(command);
            string[] container = information.Split(' ');
            name.text = container[0].Substring(6, container[0].Length - 7);
            bday.text = container[1].Substring(6, container[1].Length - 7);
            mobile.text = container[2].Substring(8, container[2].Length - 9);
            discord.text = container[3].Substring(9, container[3].Length - 10);
            interest.text = container[4].Substring(10, container[4].Length - 11);
            notes.text = container[5].Substring(7, container[5].Length - 8);      
        }
    }

    public void submit(){
        string id = command;
        // controller.SetGroup(newGroupName.text, id);
        /*Dictionary<string, List<string>> temp = controller.GetGroupMap();
        foreach(string x in temp.Keys){
            Debug.Log(x);
        }*/

        string txtLine =  $"Name:\"{name.text}\" Bday:\"{bday.text}\" Mobile:\"{mobile.text}\" Discord:\"{discord.text}\" Interest:\"{interest.text}\" Notes:\"{notes.text}\"";
        if(name.text.Length == 0 && bday.text.Length == 0 && mobile.text.Length == 0 && discord.text.Length == 0 && interest.text.Length == 0 && notes.text.Length == 0 ){
            Debug.Log("user not input anything");
        } else {
            if(command == "create new"){
                string tempId = controller.IdGenerator();
                controller.SetIndividual(tempId, txtLine);
                contact.submitNewCard(name.text, tempId);
            } else {
                controller.SetIndividual(id,txtLine);
            }
        }
    }
}
