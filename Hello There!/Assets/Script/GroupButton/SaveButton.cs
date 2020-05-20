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
    public TextMeshProUGUI  newContact, newGroupName;
    public GameObject ContactListPage;
    public TMP_InputField discord, interest, mobile, bday ,name, notes;
    public Toggle[] Toggle;

    private contactlist contact;
    private GroupInformationcontrol controller;
    private string command;
    void Start()
    {
        contact = ContactListPage.GetComponent<contactlist>();
        controller = Canvas.GetComponent<GroupInformationcontrol>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnEnable() {
        contact = ContactListPage.GetComponent<contactlist>();
        controller = Canvas.GetComponent<GroupInformationcontrol>();
        command = PlayerPrefs.GetString("id");
        if(command == "create new"){
            discord.text = "";
            interest.text = "";
            mobile.text = "";
            bday.text = "";
            name.text = "";
            notes.text = "";
            foreach (var item in Toggle)
            {
                item.isOn = false;
            }
        } else {
            string information = controller.GetIndividual(command);
            string[] container = information.Split(' ');       
            name.text = container[0].Substring(6, container[0].Length - 7).Replace("*", " ");
            bday.text = container[1].Substring(6, container[1].Length - 7).Replace("*", " ");
            mobile.text = container[2].Substring(8, container[2].Length - 9).Replace("*", " ");
            discord.text = container[3].Substring(9, container[3].Length - 10).Replace("*", " ");
            interest.text = container[4].Substring(10, container[4].Length - 11).Replace("*", " ");
            notes.text = container[5].Substring(7, container[5].Length - 8).Replace("*", " ");  
            for(int i = 1; i < Toggle.Length; i++){
                Toggle[i].isOn = container[6].Contains($"{i}");
            }    
        }
    }

    public void submit(){
        string id = command;
        string Notify = "";
        for(int i = 1; i < Toggle.Length; i++)
        {
            if(Toggle[i].isOn){
                Notify += $"{i}";
            }
        }
        Debug.Log(Notify);

        string txtLine =  $"Name:\"{name.text.Replace(" ", "*")}\" Bday:\"{bday.text.Replace(" ", "*")}\" Mobile:\"{mobile.text.Replace(" ", "*")}\" Discord:\"{discord.text.Replace(" ", "*")}\" Interest:\"{interest.text.Replace(" ", "*")}\" Notes:\"{notes.text.Replace(" ", "*")}\" Reminders:\"{Notify}\"";
        if(name.text.Length == 0 && bday.text.Length == 0 && mobile.text.Length == 0 && discord.text.Length == 0 && interest.text.Length == 0 && notes.text.Length == 0 ){
            Debug.Log("user not input anything");
        } else {
            if(command == "create new"){
                if(name.text.Length == 0){
                    Debug.Log("User didnt create new name");
                    return;
                }
                string tempId = controller.IdGenerator();
                controller.SetIndividual(tempId, txtLine);
                contact.submitNewCard(name.text, tempId);
            } else {
                contact.changeCardText(id, name.text);
                controller.SetIndividual(id,txtLine);
            }
        }
    }
}
